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

    // Step 구조로 생성된 currentStep, nextStep이다.
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
        dbRef = FirebaseDatabase.DefaultInstance.RootReference; // 상위 주소 참조함.

        currentStep.angleAxis1 = 0;
        currentStep.angleAxis2 = 0;
        currentStep.angleAxis3 = 0;
        currentStep.angleAxis4 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // ESC를 눌렀을때 종료
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
                print("데이터 다운로드 취소");
            }
            else if (task.IsFaulted)
            {
                print("데이터 다운로드 실패");
            }
            else if (task.IsCompleted)
            {
                allDataStr = "";

                print("데이터 다운로드 성공!");

                DataSnapshot snapshot = task.Result;
                foreach (DataSnapshot item in snapshot.Children)
                {
                    IDictionary Crud_Robotaxis = (IDictionary)item.Value;

                    // 각 축의 값을 로그로 출력
                    Debug.Log("Axis1Value: " + item.Child("Axis1Value").Value);
                    Debug.Log("Axis2Value: " + item.Child("Axis2Value").Value);
                    Debug.Log("Axis3Value: " + item.Child("Axis3Value").Value);
                    Debug.Log("Axis4Value: " + item.Child("Axis4Value").Value);

                    angleAxis1 = item.Child("Axis1Value").Value.ToString();
                    angleAxis2 = item.Child("Axis2Value").Value.ToString();
                    angleAxis3 = item.Child("Axis3Value").Value.ToString();
                    angleAxis4 = item.Child("Axis4Value").Value.ToString();

                    // Parse로 문자열 -> float열로 변경하여 가져감
                    nextStep.angleAxis1 = float.Parse(angleAxis1);
                    nextStep.angleAxis2 = float.Parse(angleAxis2);
                    nextStep.angleAxis3 = float.Parse(angleAxis3);
                    nextStep.angleAxis4 = float.Parse(angleAxis4);

                    InputField1.text = angleAxis1;
                    InputField2.text = angleAxis2;
                    InputField3.text = angleAxis3;
                    InputField4.text = angleAxis4;
                    break;

                    // 전체 다 불러오는 코드
                    //string json = snapshot.GetRawJsonValue();

                    //JObject totalData = JObject.Parse(json);
                }
                // 이전 스텝에서 다음 스텝으로 넘어가는 코드
                StartCoroutine(RunOrigin(currentStep, nextStep));

                currentStep.angleAxis1 = nextStep.angleAxis1;
                currentStep.angleAxis2 = nextStep.angleAxis2;
                currentStep.angleAxis3 = nextStep.angleAxis3;
                currentStep.angleAxis4 = nextStep.angleAxis4;
            }
        };
    }
    IEnumerator RunOrigin(Step currentStep, Step nextStep)
    {

        Vector3 prevAxis1Euler = new Vector3(0, currentStep.angleAxis1, 0); // Axis1: Y축 기준으로 회전
        Vector3 nextAxis1AEuler = new Vector3(0, -nextStep.angleAxis1, 0);

        Vector3 prevAxis2Euler = new Vector3(0, 0, currentStep.angleAxis2); // Axis2: Z축 기준으로 회전
        Vector3 nextAxis2AEuler = new Vector3(0, 0, -nextStep.angleAxis2);

        Vector3 prevAxis3Euler = new Vector3(0, 0, currentStep.angleAxis3); // Axis3: Z축 기준으로 회전
        Vector3 nextAxis3AEuler = new Vector3(0, 0, -nextStep.angleAxis3);

        Vector3 prevAxis4Euler = new Vector3(0, 0, currentStep.angleAxis4); // Axis4: Z축 기준으로 회전
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
            StartCoroutine(DownloadData());
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
        // 각 축의 값을 로그로 출력
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

        Vector3 prevAxis1Euler = new Vector3(0, -currentStep.angleAxis1, 0); // Axis1: Y축 기준으로 회전
        Vector3 nextAxis1AEuler = new Vector3(0, 0, 0);

        Vector3 prevAxis2Euler = new Vector3(0, 0, -currentStep.angleAxis2); // Axis2: Z축 기준으로 회전
        Vector3 nextAxis2AEuler = new Vector3(0, 0, 0);

        Vector3 prevAxis3Euler = new Vector3(0, 0, currentStep.angleAxis3); // Axis3: Z축 기준으로 회전
        Vector3 nextAxis3AEuler = new Vector3(0, 0, 0);

        Vector3 prevAxis4Euler = new Vector3(0, 0, currentStep.angleAxis4); // Axis4: Z축 기준으로 회전
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

