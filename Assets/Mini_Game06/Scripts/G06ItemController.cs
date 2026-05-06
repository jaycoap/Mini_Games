using UnityEngine;

public class G06ItemController : MonoBehaviour
{
    public float dropSpeed = -0.03f;

    void Update()
    {
        transform.Translate(0, dropSpeed, 0);
        if (transform.position.y < -1.0f)
        {
            Destroy(gameObject);
        }
    }
}
