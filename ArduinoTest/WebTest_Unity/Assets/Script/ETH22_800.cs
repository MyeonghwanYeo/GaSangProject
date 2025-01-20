using UnityEngine;

public class SliderMotorControl : MonoBehaviour
{
    public float speed = 0.1f; // 이동하는 기본 속도
    public float position = 0; // 목표 위치
    public float slowDownDistance = 1.0f; // 감속 시작 거리

    Vector3 pos = new Vector3(0, 0, 0);

    void Start()
    {
    }

    void Update()
    {
        pos = new Vector3(Map(position), 0, 0);
        Vector3 direction = pos - transform.localPosition;

        // 현재 방향으로 이동
        float distance = direction.magnitude;

        // 감속 로직
        float currentSpeed = speed;
        if (distance < slowDownDistance)
        {
            // 목표 위치에 가까워질수록 속도를 줄임
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