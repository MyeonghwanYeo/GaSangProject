using UnityEngine;

public class JigIn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        print("일단감지");
        // 충돌한 객체에 Rigidbody가 있는지 확인
        if (other.attachedRigidbody != null && other.tag == "Core")
        {
            // 충돌한 객체를 현재 객체의 자식으로 설정
            other.transform.SetParent(transform);

            print("감지");
        }
        else
        {
            print("뭐가안댐");
            other.transform.SetParent(null);
        }
    }
}
