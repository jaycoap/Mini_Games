using UnityEngine;

public class G04PlayerController : MonoBehaviour
{
    Rigidbody2D rigid;
    Animator anim;
    float jumpForce = 360.0f;
    float walkforce = 30.0f;
    float maxSpeed = 2.0f;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(transform.up * jumpForce);
        }

        int key = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            key = -1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            key = 1;
        }

        float speed = Mathf.Abs(rigid.linearVelocity.x);
        if (speed < maxSpeed)
        {
            rigid.AddForce(transform.right * key * walkforce);
        }
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1,1);
        }
        anim.speed = speed / 2.0f;
    }
}
