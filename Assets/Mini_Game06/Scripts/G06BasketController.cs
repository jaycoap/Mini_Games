using UnityEditor.PackageManager;
using UnityEngine;

public class G06BasketController : MonoBehaviour
{
    public AudioClip appleSound;
    public AudioClip leseSound;
    G06GameDirector director;
    AudioSource audioSource;

    void Start()
    {
        director = GameObject.Find("G06GameDirector").GetComponent<G06GameDirector>();
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, 0, z);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Apple")
        {
           
            director.GetApple();
            Debug.Log("This is Apple!");
            audioSource.PlayOneShot(appleSound);
        }
        else
        {
            director.GetBomb();
            Debug.Log("This is Lese");
            audioSource.PlayOneShot(leseSound);
        }
        Destroy(other.gameObject);   
    }



}
