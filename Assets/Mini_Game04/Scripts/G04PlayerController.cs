using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class G04PlayerController : MonoBehaviour
{
    Rigidbody2D rigid;
    Animator anim;
    float jumpForce = 360.0f;
    float walkforce = 30.0f;
    float maxSpeed = 2.0f;
    float threshold = 0.2f;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if ((Input.GetMouseButtonDown(0) && rigid.linearVelocity.y == 0) || (Input.GetKeyDown(KeyCode.Space) && rigid.linearVelocity.y == 0))
        {
            anim.SetTrigger("Jump_Trigger");
            rigid.AddForce(transform.up * jumpForce);
            
        }

        int key = 0;
        if (Input.GetKey(KeyCode.A))
        {
            key = -1;
            anim.SetTrigger("Walk_Trigger");
        }
        else if (Input.GetKey(KeyCode.D))
        {            
            key = 1;
            anim.SetTrigger("Walk_Trigger");
        }
        else if (rigid.linearVelocity.y == 0)
        {
            anim.SetTrigger("Idle_Trigger");
        }

        if (Input.acceleration.x > threshold)
        {
            key = 1;
        }
        if (Input.acceleration.x < -threshold)
        {
            key = -1;
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
        if(rigid.linearVelocity.y == 0)
        {
            anim.speed = speed / 2.0f;
        }
        else
        {
            anim.speed = 1.0f;
        }
        if (transform.position.y < -10)
        {
            SceneManager.LoadScene("GameScene04");
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("골");
        SceneManager.LoadScene("GameScene04b");
    }

    public void ReturnLobby04()
    {
        LB_SceneController.LoadLobby();
    }
}
