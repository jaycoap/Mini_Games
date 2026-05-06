using UnityEngine;

public class G05BamsoniGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            GameObject bamsongi = Instantiate(bamsongiPrefab);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;     
            bamsongi.GetComponent<G05BamsongiController>().Shoot(worldDir.normalized * 2000);
            Debug.Log(worldDir*2000);
        }
    }
}
