using System;
using System.Collections;
using System.Net.Sockets;
using System.Text;
using TMPro;
using UnityEngine;
using System.Threading.Tasks;

public class TCPClientEx : MonoBehaviour
{
    public float waitTime = 0.5f;
    public Transform obj;
    public Transform pointA;
    public Transform pointB;
    private bool isConnected;
    NetworkStream stream;
    TcpClient client;

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
            print("서버를 먼저 작동시켜 주세요.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) // ESC를 눌렀을때 종료
        {
            Application.Quit();
        }
    }

    // 코루틴 사용 동기화 요청 버튼
    private bool isCoroutineRunning = false; // 코루틴 실행 상태를 추적하는 변수

    public void OnConnectBtnClkEvent()
    {
            if (!isConnected)
                {
                    isConnected = true;

                    //string ret = Request("Connect");

                    //print(ret);

                    // 연결 요청 후에 C_DATA 요청을 위한 코루틴 시작
                    StartCoroutine(CoSyncRequest());

                   // Task.Run(() => RequestAsync("C_DATA"));
                }
            else
                {
                    print("이미 연결된 상태입니다.");
                }
    }

    IEnumerator CoSyncRequest()
    {
        while (isConnected)
        {
            string ret = Request("C_DATA");
            print(ret);

            yield return new WaitForSeconds(waitTime);
        }
    }

    private string Request(string message)
    {
        // 데이터 송신
        byte[] requestData = Encoding.UTF8.GetBytes(message);
        stream.WriteAsync(requestData, 0, requestData.Length);

        // 데이터 수신
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
            print("이미 연결해지 상태입니다.");
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
                Debug.Log("받은 메시지: " + message);
            }
        }
    }
}
