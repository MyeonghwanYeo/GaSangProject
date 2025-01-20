using UnityEngine;

public class Nipper : MonoBehaviour
{
    [SerializeField] GameObject motorLink; // MotorLink ������Ʈ
    [SerializeField] GameObject motorAxs;  // MotorAxs ������Ʈ (ȸ�� �߽�)

    // ȸ�� �ӵ� (�ʴ� �� �� ȸ������ ����)
    [SerializeField] float rotationSpeed = 30f; // �ʴ� ȸ�� �ӵ� (�� ����)
    private float initialRotation1;

    // Start�� MonoBehaviour�� ó�� ����� �� �� �� ȣ��˴ϴ�.
    void Start()
    {
        // motorLink�� �ʱ� Z�� ȸ�� ������ ����
        initialRotation1 = motorLink.transform.rotation.eulerAngles.z;
    }

    // Update�� �� �����Ӹ��� ȣ��˴ϴ�.
    void Update()
    {
        // Mathf.PingPong�� ����� 0������ 45�� ���̷� �ε巴�� ȸ��
        float angle1 = Mathf.PingPong(Time.time * rotationSpeed, 45f);

        // motorLink�� Z���� �������� angle��ŭ ȸ����Ŵ
        motorLink.transform.rotation = Quaternion.Euler(motorLink.transform.rotation.eulerAngles.x, motorLink.transform.rotation.eulerAngles.y, initialRotation1 + angle1);
    }
}