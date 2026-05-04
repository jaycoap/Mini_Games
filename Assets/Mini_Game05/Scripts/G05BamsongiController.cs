using UnityEngine;

public class G05BamsongiController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    void Start()
    {
        Shoot(new Vector3(0, 200, 2000));
    }

    void Shoot(Vector3 dir){
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;       
    }
}
