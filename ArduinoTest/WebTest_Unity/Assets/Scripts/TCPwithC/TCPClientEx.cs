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
            print("������ ���� �۵����� �ּ���.");
        }
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
