using UnityEngine;

public class G05BamsongiController : MonoBehaviour
{
    

    void Start()
    {

    }

    public void Shoot(Vector3 dir){
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;       
        GetComponentInChildren<ParticleSystem>().Play();
    }
}
