using UnityEngine;

public class G03KittyController:MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.3f,0,0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.3f,0,0);
        }
    }
}
