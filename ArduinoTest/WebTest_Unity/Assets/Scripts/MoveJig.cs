using System.Collections;
using UnityEngine;

public class MoveJig : MonoBehaviour
{
    public static MoveJig instance;

    // 목표 회전을 저장할 변수
    public Quaternion targetRotation;
    public Transform moveJig;
    public Transform moveSt1;
    public Transform moveSt2;

    // 시작 위치와 목표 위치를 저장할 변수
    private Vector3 startPosition;
    private Vector3 targetPosition = new Vector3(0.08f, 0.15f, 0f);

    // 이동 시간과 대기 시간을 설정
    private float moveDuration = 1.0f;
    private float waitDuration = 1.0f;

    // 이동 상태를 추적할 변수
    private bool isMoving = false;

    public bool stStart = false;
    public bool stripped1 = false;
    public bool stripped2 = false;
    public bool stripped3 = false;
    public bool stripped4 = false;

    public float rotationSpeed = 1.0f;


    public void Awake()
    {
        if (MoveJig.instance == null)
        {
            MoveJig.instance = this;
        }
    }

    void Start()
    {
        startPosition = moveSt1.localPosition;
    }

    void Update()
    {



        if (stStart && !isMoving)
        {
            StartCoroutine(seq2());
            stStart = false;
        }

    }

    IEnumerator seq2()
    {
        yield return doMoveJig(15);
        yield return MoveObjectCoroutine(moveSt1);
        stripped1 = true;
        yield return doMoveJig(-15);
        yield return MoveObjectCoroutine(moveSt1);
        stripped2 = true;
        yield return doMoveJig(-25);
        yield return MoveObjectCoroutine(moveSt2);
        stripped3 = true;
        yield return doMoveJig(25);
        yield return MoveObjectCoroutine(moveSt2);
        stripped4 = true;


    }

    IEnumerator doMoveJig(float angle)
    {
        rotationSpeed = 1f; // 회전하는 데 걸리는 총 시간 (초 단위)
        float elapsedTime = 0f; // 경과된 시간
        targetRotation = Quaternion.Euler(0f, angle, 0f);

        while (elapsedTime < rotationSpeed)
        {
            // 경과 시간을 업데이트
            elapsedTime += Time.deltaTime;

            float t = Mathf.Clamp01(elapsedTime / rotationSpeed);

            // 현재 회전에서 목표 회전으로 보간
            moveJig.localRotation = Quaternion.Slerp(moveJig.localRotation, targetRotation, (elapsedTime / rotationSpeed));

            yield return new WaitForEndOfFrame();
        }

    }




    private IEnumerator MoveObjectCoroutine(Transform transform)
    {
        isMoving = true;
        // 목표 위치로 이동
        yield return StartCoroutine(MoveToPosition(transform, targetPosition));

        // 대기 시간
        yield return new WaitForSeconds(waitDuration);
      

        // 시작 위치로 되돌아감
        yield return StartCoroutine(MoveToPosition(transform, startPosition));

        isMoving = false;
    }

    private IEnumerator MoveToPosition(Transform transform, Vector3 destination)
    {
        float elapsedTime = 0f;
        Vector3 initialPosition = transform.localPosition;

        while (elapsedTime < moveDuration)
        {
            // Slerp를 이용해 부드럽게 위치 보간
            transform.localPosition = Vector3.Lerp(initialPosition, destination, elapsedTime / moveDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // 정확한 위치 설정
        transform.localPosition = destination;

    }

    
}
