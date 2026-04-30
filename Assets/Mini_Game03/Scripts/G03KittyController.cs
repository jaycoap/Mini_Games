using UnityEngine;

public class G03KittyController:MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.3f,0,0);
            GameObject spriteRenderer = GameObject.Find("Doro");
            spriteRenderer.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.3f,0,0);
            GameObject spriteRenderer = GameObject.Find("Doro");
            spriteRenderer.GetComponent<SpriteRenderer>().flipX = true;
        }
    }

    public void LButtonDown()
    {
        transform.Translate(-0.3f,0,0);
        GameObject spriteRenderer = GameObject.Find("Doro");
        spriteRenderer.GetComponent<SpriteRenderer>().flipX = false;
    }
    public void RButtonDown()
    {
        transform.Translate(0.3f,0,0);
        GameObject spriteRenderer = GameObject.Find("Doro");
        spriteRenderer.GetComponent<SpriteRenderer>().flipX = true;
    }
}
