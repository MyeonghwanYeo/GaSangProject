using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public static MoveObject instance;
    public void Awake()
    {
        if (MoveObject.instance == null)
        {
            MoveObject.instance = this;
        }
    }

    // �̵��� ��ǥ ��ġ
    private Vector3 targetPosition = new Vector3(-0.72766f, 1.1785f, -0.8567f);
    // �ʱ� ��ġ ����
    private Vector3 initialPosition;
    // �̵� �ӵ�
    public float speed = 0.2f;
    // ���� ��ǥ ��ġ
  
    public bool isMoving = false;   // <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<��ư�� ������ ��
    public bool moveDone = false;
    private bool isReturning = false; // �ǵ��ư��� ����

    private float waitTime = 1.0f; // ��� �ð�
    private float waitTimer = 0.0f; // Ÿ�̸�

    void Start()
    {
        initialPosition = transform.localPosition; // �ʱ� ��ġ ����
    }

    void Update()
    { 
        
        if (isMoving)
        {
            // �ε巴�� �̵��ϱ�
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, targetPosition, speed * Time.deltaTime);

            // ��ǥ ��ġ�� �����ߴ��� Ȯ��
            if (Vector3.Distance(transform.localPosition, targetPosition) < 0.01f)
            {
                isMoving = false; // �̵� �Ϸ�
                waitTimer = 0.0f; // Ÿ�̸� �ʱ�ȭ
                isReturning = true; // �ǵ��ư��� ���·� ����
                moveDone = true;
            }
        }
        else if (isReturning)
        {
            // ��� �ð� ī��Ʈ
            waitTimer += Time.deltaTime;

            // ��� �ð� ���� ���
            if (waitTimer >= waitTime)
            {
                // �ʱ� ��ġ�� �ε巴�� �̵�
                transform.localPosition = Vector3.MoveTowards(transform.localPosition, initialPosition, speed * Time.deltaTime);

                // �ʱ� ��ġ�� �����ߴ��� Ȯ��
                if (Vector3.Distance(transform.localPosition, initialPosition) < 0.01f)
                {
                    isReturning = false; // �ǵ��ư��� �Ϸ�
                   
                }
            }
        }
        
    }
}


