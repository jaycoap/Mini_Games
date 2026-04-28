using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class G02CarController : MonoBehaviour
{

    float speed = 0;
    Vector2 startPos;
    Vector2 endPos;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;

        }
        else if (Input.GetMouseButtonUp(0))
        {
            endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;
            speed = swipeLength / 500.0f;
            GetComponent<AudioSource>().Play();
        }
        transform.Translate(speed, 0,0);
        speed *= 0.98f;
        
    }
}