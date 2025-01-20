using UnityEngine;

public class Nipper : MonoBehaviour
{
    [SerializeField] GameObject motorLink; // MotorLink 오브젝트
    [SerializeField] GameObject motorAxs;  // MotorAxs 오브젝트 (회전 중심)

    // 회전 속도 (초당 몇 도 회전할지 설정)
    [SerializeField] float rotationSpeed = 30f; // 초당 회전 속도 (도 단위)
    private float initialRotation1;

    // Start는 MonoBehaviour가 처음 실행될 때 한 번 호출됩니다.
    void Start()
    {
        // motorLink의 초기 Z축 회전 각도를 저장
        initialRotation1 = motorLink.transform.rotation.eulerAngles.z;
    }

    // Update는 매 프레임마다 호출됩니다.
    void Update()
    {
        // Mathf.PingPong을 사용해 0도에서 45도 사이로 부드럽게 회전
        float angle1 = Mathf.PingPong(Time.time * rotationSpeed, 45f);

        // motorLink를 Z축을 기준으로 angle만큼 회전시킴
        motorLink.transform.rotation = Quaternion.Euler(motorLink.transform.rotation.eulerAngles.x, motorLink.transform.rotation.eulerAngles.y, initialRotation1 + angle1);
    }
}