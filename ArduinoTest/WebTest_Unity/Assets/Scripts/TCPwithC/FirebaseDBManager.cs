using System.Collections;
using UnityEngine;
using Firebase.Database;
using System;
using Newtonsoft.Json.Linq;
using System.Net.Sockets;
using TMPro;
using static UnityEditor.Progress;

public class FirebaseDBManager : MonoBehaviour
{
    [Serializable]
    public class Step
    {
        public int stepNumber;
        public float speed = 100;
        public float duration;
        public bool isSuctionOn;

        public float angleAxis1;
        public float minAngleAxis1;
        public float maxAngleAxis1;

        public float angleAxis2;
        public float minAngleAxis2;
        public float maxAngleAxis2;

        public float angleAxis3;
        public float minAngleAxis3;
        public float maxAngleAxis3;

        public float angleAxis4;
        public float minAngleAxis4;
        public float maxAngleAxis4;
    }

    public float cycleTime;
    public float waitTime = 1.0f;
    public float message_angle1;
    public float message_angle2;
    public float message_angle3;
    public float message_angle4;
    private bool isConnected;
    public string angleAxis1;
    public string angleAxis2;
    public string angleAxis3;
    public string angleAxis4;

    NetworkStream stream;
    TcpClient client;

    [SerializeField] TMP_InputField InputField1;
    [SerializeField] TMP_InputField InputField2;
    [SerializeField] TMP_InputField InputField3;
    [SerializeField] TMP_InputField InputField4;

    [Header("Axis Pivots")]
    [SerializeField] Transform motorAxis1;
    [SerializeField] Transform motorAxis2;
    [SerializeField] Transform motorAxis3;
    [SerializeField] Transform motorAxis4;

    // Step ������ ������ currentStep, nextStep�̴�.
    public Step currentStep = new Step();
    public Step nextStep = new Step();

    public string dbURL;
    DatabaseReference dbRef;
    JObject totalData;
    private string allDataStr;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Firebase.FirebaseApp.DefaultInstance.Options.DatabaseUrl = new Uri(dbURL);
        dbRef = FirebaseDatabase.DefaultInstance.RootReference; // ���� �ּ� ������.

        currentStep.angleAxis1 = 0;
        currentStep.angleAxis2 = 0;
        currentStep.angleAxis3 = 0;
        currentStep.angleAxis4 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // ESC�� �������� ����
        {
            Application.Quit();
        }
    }

    private IEnumerator DownloadData()
    {
        if (dbRef != null)
        {
            var task = dbRef.Child("Arduino").GetValueAsync();
            yield return new WaitUntil(() => task.IsCompleted);

            if (task.IsCanceled)
            {
                print("������ �ٿ�ε� ���");
            }
            else if (task.IsFaulted)
            {
                print("������ �ٿ�ε� ����");
            }
            else if (task.IsCompleted)
            {
                allDataStr = "";

                print("������ �ٿ�ε� ����!");

                DataSnapshot snapshot = task.Result;
                foreach (DataSnapshot item in snapshot.Children)
                {
                    IDictionary Crud_Robotaxis = (IDictionary)item.Value;

                    // �� ���� ���� �α׷� ���
                    Debug.Log("Axis1Value: " + item.Child("Axis1Value").Value);
                    Debug.Log("Axis2Value: " + item.Child("Axis2Value").Value);
                    Debug.Log("Axis3Value: " + item.Child("Axis3Value").Value);
                    Debug.Log("Axis4Value: " + item.Child("Axis4Value").Value);

                    angleAxis1 = item.Child("Axis1Value").Value.ToString();
                    angleAxis2 = item.Child("Axis2Value").Value.ToString();
                    angleAxis3 = item.Child("Axis3Value").Value.ToString();
                    angleAxis4 = item.Child("Axis4Value").Value.ToString();

                    // Try Parse�� float �������µ� ���� ������ �״�� �ƴϸ� 0
                    float newAxis1 = 0;
                    float newAxis2 = 0;
                    float newAxis3 = 0;
                    float newAxis4 = 0;

                    newAxis1 = (float.TryParse(angleAxis1, out newAxis1)) ? newAxis1 : 0;
                    newAxis2 = (float.TryParse(angleAxis2, out newAxis2)) ?  newAxis2 : 0;
                    newAxis3 = (float.TryParse(angleAxis3, out newAxis3)) ? newAxis3 : 0;
                    newAxis4 = (float.TryParse(angleAxis4, out newAxis4)) ? newAxis4 : 0;

                    // ���� ���� ���Ͽ� ����� ��쿡�� ������Ʈ
                    if (newAxis1 != currentStep.angleAxis1 ||
                        newAxis2 != currentStep.angleAxis2 ||
                        newAxis3 != currentStep.angleAxis3 ||
                        newAxis4 != currentStep.angleAxis4)
                    {
                        nextStep.angleAxis1 = newAxis1;
                        nextStep.angleAxis2 = newAxis2;
                        nextStep.angleAxis3 = newAxis3;
                        nextStep.angleAxis4 = newAxis4;

                        // UI ������Ʈ
                        InputField1.text = angleAxis1;
                        InputField2.text = angleAxis2;
                        InputField3.text = angleAxis3;
                        InputField4.text = angleAxis4;

                        // ���� ��ġ ������Ʈ
                        StartCoroutine(RunOrigin(currentStep, nextStep));

                        // ���� ���� ������Ʈ
                        currentStep.angleAxis1 = nextStep.angleAxis1;
                        currentStep.angleAxis2 = nextStep.angleAxis2;
                        currentStep.angleAxis3 = nextStep.angleAxis3;
                        currentStep.angleAxis4 = nextStep.angleAxis4;
                    }
                    else
                    {
                        Debug.Log("����� �����Ͱ� ���� ������Ʈ�� �ǳʶݴϴ�.");
                    }
                    break;
                }
            }
        };
    }

    // Firebase�� ���� ������ ���� ����ȭ
    IEnumerator Arduino2unity()
    {
        var task = dbRef.Child("Arduino").GetValueAsync();
        yield return new WaitUntil(() => task.IsCompleted);

        if (task.IsCanceled)
        {
            print("������ �ٿ�ε� ���");
        }
        else if (task.IsFaulted)
        {
            print("������ �ٿ�ε� ����");
        }
        else if (task.IsCompleted)
        {
            isConnected = true;
        }
            while (isConnected)
        {
            yield return DownloadData();
            yield return new WaitForEndOfFrame();
        }
    }

    IEnumerator RunOrigin(Step currentStep, Step nextStep)
    {



        Vector3 prevAxis1Euler = new Vector3(0, currentStep.angleAxis1, 0); // Axis1: Y�� �������� ȸ��
        Vector3 nextAxis1AEuler = new Vector3(0, -nextStep.angleAxis1, 0);

        Vector3 prevAxis2Euler = new Vector3(0, 0, currentStep.angleAxis2); // Axis2: Z�� �������� ȸ��
        Vector3 nextAxis2AEuler = new Vector3(0, 0, -nextStep.angleAxis2);

        Vector3 prevAxis3Euler = new Vector3(0, 0, currentStep.angleAxis3); // Axis3: Z�� �������� ȸ��
        Vector3 nextAxis3AEuler = new Vector3(0, 0, -nextStep.angleAxis3);

        Vector3 prevAxis4Euler = new Vector3(0, 0, currentStep.angleAxis4); // Axis4: Z�� �������� ȸ��
        Vector3 nextAxis4AEuler = new Vector3(0, 0, nextStep.angleAxis4);

        float currentTime = 0;


        while (currentTime < (currentStep.speed * 0.01f))
        {
            currentTime += Time.deltaTime;

            motorAxis1.localRotation = RotateAngle(prevAxis1Euler, nextAxis1AEuler, currentTime / (currentStep.speed * 0.01f));
            motorAxis2.localRotation = RotateAngle(prevAxis2Euler, nextAxis2AEuler, currentTime / (currentStep.speed * 0.01f));
            motorAxis3.localRotation = RotateAngle(prevAxis3Euler, nextAxis3AEuler, currentTime / (currentStep.speed * 0.01f));
            motorAxis4.localRotation = RotateAngle(prevAxis4Euler, nextAxis4AEuler, currentTime / (currentStep.speed * 0.01f));

            //cycleTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
    }


    private Quaternion RotateAngle(Vector3 from, Vector3 to, float t)
    {
        return Quaternion.Slerp(Quaternion.Euler(from), Quaternion.Euler(to), t);
    }

    public void OnConnectBtnClkEvent()
    {
        if (dbRef != null)
        {
            StartCoroutine(Arduino2unity());
        }

        //InitializeData();
        //UploadData();
    }

    public void OnDisconnectBtnClkEvent()
    {
        StartCoroutine(MovetozeroPosition());
    }

    IEnumerator MovetozeroPosition()
    {
        // �� ���� ���� �α׷� ���
        Debug.Log("Axis1Value: 0");
        Debug.Log("Axis2Value: 0");
        Debug.Log("Axis3Value: 0");
        Debug.Log("Axis4Value: 0");

        angleAxis1 = "0";
        angleAxis2 = "0";
        angleAxis3 = "0";
        angleAxis4 = "0";

        InputField1.text = "0";
        InputField2.text = "0";
        InputField3.text = "0";
        InputField4.text = "0";

        Vector3 prevAxis1Euler = new Vector3(0, -currentStep.angleAxis1, 0); // Axis1: Y�� �������� ȸ��
        Vector3 nextAxis1AEuler = new Vector3(0, 0, 0);

        Vector3 prevAxis2Euler = new Vector3(0, 0, -currentStep.angleAxis2); // Axis2: Z�� �������� ȸ��
        Vector3 nextAxis2AEuler = new Vector3(0, 0, 0);

        Vector3 prevAxis3Euler = new Vector3(0, 0, currentStep.angleAxis3); // Axis3: Z�� �������� ȸ��
        Vector3 nextAxis3AEuler = new Vector3(0, 0, 0);

        Vector3 prevAxis4Euler = new Vector3(0, 0, currentStep.angleAxis4); // Axis4: Z�� �������� ȸ��
        Vector3 nextAxis4AEuler = new Vector3(0, 0, 0);

        float currentTime = 0;

        while (currentTime < (currentStep.speed * 0.01f))
        {
            currentTime += Time.deltaTime;

            motorAxis1.localRotation = RotateAngle(prevAxis1Euler, nextAxis1AEuler, currentTime / (currentStep.speed * 0.01f));
            motorAxis2.localRotation = RotateAngle(prevAxis2Euler, nextAxis2AEuler, currentTime / (currentStep.speed * 0.01f));
            motorAxis3.localRotation = RotateAngle(prevAxis3Euler, nextAxis3AEuler, currentTime / (currentStep.speed * 0.01f));
            motorAxis4.localRotation = RotateAngle(prevAxis4Euler, nextAxis4AEuler, currentTime / (currentStep.speed * 0.01f));

            //cycleTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
    }
}

