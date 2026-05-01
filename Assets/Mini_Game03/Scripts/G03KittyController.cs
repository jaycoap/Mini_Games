using UnityEngine;

public class G03KittyController:MonoBehaviour
{
    Animator anim;
    void Start()    {
        anim = GetComponent<Animator>();
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            LButtonDown();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            RButtonDown();
        }
    }

    public void LButtonDown()
    {
        transform.Translate(-0.3f,0,0);
        GameObject spriteRenderer = GameObject.Find("Doro");
        spriteRenderer.GetComponent<SpriteRenderer>().flipX = false;
        anim.SetTrigger("Walk_Trigger");

    }
    public void RButtonDown()
    {
        transform.Translate(0.3f,0,0);
        GameObject spriteRenderer = GameObject.Find("Doro");
        spriteRenderer.GetComponent<SpriteRenderer>().flipX = true;
        anim.SetTrigger("Walk_Trigger");
    }
}
