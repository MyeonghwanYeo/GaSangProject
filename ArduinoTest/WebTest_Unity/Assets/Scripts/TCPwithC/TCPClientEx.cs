using System;
using System.Collections;
using System.Net.Sockets;
using System.Text;
using TMPro;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;
using UnityEngine.Rendering;
using System.Collections.Generic;

public class TCPClientEx : MonoBehaviour
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

        //public Step(int _stepNumber, float _speed, float _duration, bool _isSuctionOn)
        //{
        //    stepNumber = _stepNumber;
        //    speed = _speed;
        //    duration = _duration;
        //    isSuctionOn = _isSuctionOn;
        //}
    }

    public float cycleTime;
    public float waitTime = 1.0f;
    public float message_angle1;
    public float message_angle2;
    public float message_angle3;
    public float message_angle4;
    private bool isConnected;
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

    public List<Step> steps = new List<Step>();
    Step step1 = new Step();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
            client = new TcpClient("127.0.0.1", 7000);

            stream = client.GetStream();
        }
        catch (Exception e)
        {
            print(e);
            print("������ ���� �۵����� �ּ���.");
        }


        steps = new List<Step>();

        step1.angleAxis1 = 0;
        step1.angleAxis2 = 0;
        step1.angleAxis3 = 0;
        step1.angleAxis4 = 0;

        steps.Add(step1);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) // ESC�� �������� ����
        {
            Application.Quit();
        }
    }

    // �ڷ�ƾ ��� ����ȭ ��û ��ư
    private bool isCoroutineRunning = false; // �ڷ�ƾ ���� ���¸� �����ϴ� ����

    public void OnConnectBtnClkEvent()
    {
            if (!isConnected)
                {
                    isConnected = true;

                    //string ret = Request("Connect");

                    //print(ret);

                    // ���� ��û �Ŀ� C_DATA ��û�� ���� �ڷ�ƾ ����
                    StartCoroutine(CoSyncRequest());

                   // Task.Run(() => RequestAsync("C_DATA"));
                }
            else
                {
                    print("�̹� ����� �����Դϴ�.");
                }
    }

    IEnumerator CoSyncRequest()
    {
        while (isConnected)
        {
            string ret = Request("C_DATA");
            print(ret);

            int collect = ProcessReceivedData(ret);
            if (collect == 1)
            {
                yield return RunOrigin(steps[steps.Count-2], steps[steps.Count-1]);
            }


            yield return new WaitForSeconds(waitTime);
        }
    }

    private string Request(string message)
    {
        // ������ �۽�
        byte[] requestData = Encoding.UTF8.GetBytes(message);
        stream.WriteAsync(requestData, 0, requestData.Length);

        // ������ ����
        byte[] buffer = new byte[1024];
        int nBytes = stream.Read(buffer, 0, buffer.Length);
        string responseData = Encoding.UTF8.GetString(buffer, 0, nBytes);

        return responseData;
    }

    private async Task RequestAsync(string msg)
    {
        while (isConnected)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(msg);

            await stream.WriteAsync(buffer, 0, buffer.Length);

            byte[] buffer2 = new byte[1024];
            int nBytes = await stream.ReadAsync(buffer2, 0, buffer2.Length);
            string message = Encoding.UTF8.GetString(buffer2, 0, nBytes);
            print(message);

            if (message.Contains("Quit"))
                break;
        }
    }

    // �� �޼���� �����κ��� ���� �޽����� ó���մϴ�.
    public int ProcessReceivedData(string data)
    {
        // ������ ���ڿ��� �Ľ��Ͽ� �� ���� �����մϴ�.
        string[] values = data.Trim('(', ')').Split(',');
         // �� ���� float�� ��ȯ�մϴ�.
         float angle1 = float.Parse(values[0]);
         float angle2 = float.Parse(values[1]);
         float angle3 = float.Parse(values[2]);
         float angle4 = float.Parse(values[3]);

        if(angle1 != steps[steps.Count - 1].angleAxis1 || angle2 != steps[steps.Count - 1].angleAxis2 || angle3 != steps[steps.Count - 1].angleAxis3 || angle4 != steps[steps.Count - 1].angleAxis4)
        {
            step1.angleAxis1 = angle1;
            step1.angleAxis2 = angle2;
            step1.angleAxis3 = angle3;
            step1.angleAxis4 = angle4;
        
            // Transform ��ü�� ȸ������ �����մϴ�. && inputField�� ȸ������ ����մϴ�.
            message_angle1 = angle1;
            message_angle2 = angle2;
            message_angle3 = angle3;
            message_angle4 = angle4;

            InputField1.text = angle1.ToString();
            InputField2.text = angle2.ToString();
            InputField3.text = angle3.ToString();
            InputField4.text = angle4.ToString();
            
            steps.Add(step1);
        }
        else
        {
            return 0;
        }

        return 1;
    }

    IEnumerator RunOrigin(Step prevStep, Step nextStep)
    {

        Vector3 prevAxis1Euler = new Vector3(0, prevStep.angleAxis1, 0); // Axis1: Y�� �������� ȸ��
        Vector3 nextAxis1AEuler = new Vector3(0, nextStep.angleAxis1, 0);

        Vector3 prevAxis2Euler = new Vector3(0, 0, prevStep.angleAxis2); // Axis2: Z�� �������� ȸ��
        Vector3 nextAxis2AEuler = new Vector3(0, 0, nextStep.angleAxis2);

        Vector3 prevAxis3Euler = new Vector3(0, 0, prevStep.angleAxis3); // Axis3: Z�� �������� ȸ��
        Vector3 nextAxis3AEuler = new Vector3(0, 0, nextStep.angleAxis3);

        Vector3 prevAxis4Euler = new Vector3(0, 0, prevStep.angleAxis4); // Axis4: Z�� �������� ȸ��
        Vector3 nextAxis4AEuler = new Vector3(0, 0, nextStep.angleAxis4);

        float currentTime = 0;
        currentTime += Time.deltaTime;

        motorAxis1.localRotation = RotateAngle(prevAxis1Euler, nextAxis1AEuler, currentTime / (prevStep.speed * 0.01f) );
        motorAxis2.localRotation = RotateAngle(prevAxis2Euler, nextAxis2AEuler, currentTime / (prevStep.speed * 0.01f));
        motorAxis3.localRotation = RotateAngle(prevAxis3Euler, nextAxis3AEuler, currentTime / (prevStep.speed * 0.01f));
        motorAxis4.localRotation = RotateAngle(prevAxis4Euler, nextAxis4AEuler, currentTime / (prevStep.speed * 0.01f));

        cycleTime += Time.deltaTime;

        yield return new WaitForEndOfFrame();
    }

    private Quaternion RotateAngle(Vector3 from, Vector3 to, float t)
    {
        return Quaternion.Slerp(Quaternion.Euler(from), Quaternion.Euler(to), t);
    }


    public void OnDisconnectBtnClkEvent()
    {
        if (isConnected)
        {
            isConnected = false;

            string ret = Request("Disconnect");

            print(ret);
        }
        else
        {
            print("�̹� �������� �����Դϴ�.");
        }
    }

    private async void ListenForMessages()
    {
        byte[] buffer = new byte[1024];
        while (true)
        {
            int nBytes = await stream.ReadAsync(buffer, 0, buffer.Length);
            if (nBytes > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, nBytes);
                Debug.Log("���� �޽���: " + message);
            }
        }
    }
}
