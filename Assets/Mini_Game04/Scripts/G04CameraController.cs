using UnityEngine;

public class G04CameraController : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        player = GameObject.Find("cat_0");
    }

    void Update()
    {
        Vector3 plyerPos = player.transform.position;
        transform.position = new Vector3(plyerPos.x, plyerPos.y, transform.position.z);
    }
}
