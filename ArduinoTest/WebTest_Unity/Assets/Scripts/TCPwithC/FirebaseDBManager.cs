using System.Collections;
using UnityEngine;
using Firebase;
using Firebase.Database;
using System;
using Newtonsoft.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Net.Sockets;
using TMPro;
using System.Collections.Generic;
using UnityEngine.UIElements;


namespace MPS
{
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

        public List<Step> steps = new List<Step>();

        public string dbURL;
        DatabaseReference dbRef;
        JObject totalData;
        private string allDataStr;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            FirebaseApp.DefaultInstance.Options.DatabaseUrl = new Uri(dbURL);
            dbRef = FirebaseDatabase.DefaultInstance.RootReference; // ���� �ּ� ������.

            if (dbRef != null)
            {
                //StartCoroutine(CoDownloadData());

                DownloadData();
            }

            //InitializeData();
            //UploadData();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape)) // ESC�� �������� ����
            {
                Application.Quit();
            }
        }

        private void DownloadData()
        {
            if (dbRef != null)
            {
                dbRef.Child("Arduino").GetValueAsync().ContinueWith(task =>
                {
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

                            //InputField1.text = item.Child("Axis1Value").Value.ToString();
                            //InputField2.text = item.Child("Axis2Value").Value.ToString();
                            //InputField3.text = item.Child("Axis3Value").Value.ToString();
                            //InputField4.text = item.Child("Axis4Value").Value.ToString();
                            break;

                            // ��ü �� �ҷ����� �ڵ�
                            //string json = snapshot.GetRawJsonValue();

                            //JObject totalData = JObject.Parse(json);
                        }
                    }
                });
            }
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


            while (currentTime < (prevStep.speed * 0.01f))
            {
                currentTime += Time.deltaTime;

                motorAxis1.localRotation = RotateAngle(prevAxis1Euler, nextAxis1AEuler, currentTime / (prevStep.speed * 0.01f));
                motorAxis2.localRotation = RotateAngle(prevAxis2Euler, nextAxis2AEuler, currentTime / (prevStep.speed * 0.01f));
                motorAxis3.localRotation = RotateAngle(prevAxis3Euler, nextAxis3AEuler, currentTime / (prevStep.speed * 0.01f));
                motorAxis4.localRotation = RotateAngle(prevAxis4Euler, nextAxis4AEuler, currentTime / (prevStep.speed * 0.01f));

                //cycleTime += Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }
        }
        private Quaternion RotateAngle(Vector3 from, Vector3 to, float t)
        {
            return Quaternion.Slerp(Quaternion.Euler(from), Quaternion.Euler(to), t);
        }
    }
}

