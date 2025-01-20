using UnityEngine;

public class SliderMotorControl : MonoBehaviour
{
    public float speed = 0.1f; // �̵��ϴ� �⺻ �ӵ�
    public float position = 0; // ��ǥ ��ġ
    public float slowDownDistance = 1.0f; // ���� ���� �Ÿ�

    Vector3 pos = new Vector3(0, 0, 0);

    void Start()
    {
    }

    void Update()
    {
        pos = new Vector3(Map(position), 0, 0);
        Vector3 direction = pos - transform.localPosition;

        // ���� �������� �̵�
        float distance = direction.magnitude;

        // ���� ����
        float currentSpeed = speed;
        if (distance < slowDownDistance)
        {
            // ��ǥ ��ġ�� ����������� �ӵ��� ����
            currentSpeed *= distance / slowDownDistance;
        }

        transform.localPosition += direction.normalized * (currentSpeed * Time.deltaTime);
    }

    public static float Map(float value)
    {
        float oldMin = 0f;
        float oldMax = 16f;
        float newMin = 0.00136f;
        float newMax = -0.01798f;

        return (value - oldMin) / (oldMax - oldMin) * (newMax - newMin) + newMin;
    }
}