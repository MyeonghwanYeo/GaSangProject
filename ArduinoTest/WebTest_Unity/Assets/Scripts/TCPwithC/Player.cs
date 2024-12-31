using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rigidbody;
    public float speed = 10f;
    public float jumpHeight = 3f;
    public float dash = 5f;
    public float rotSpeed = 3f;
    public RenderTexture renderTexture;

    private Vector3 dir = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");
        if(dir != Vector3.zero)
        {
            transform.forward = dir;
        }
       
    }
    private void FixedUpdate()
    {
        if(dir != Vector3.zero)
        {
            transform.forward = Vector3.Lerp(transform.forward, dir, rotSpeed * Time.deltaTime);
        }

        rigidbody.MovePosition(this.gameObject.transform.position + dir * speed * Time.deltaTime);
    }
}
