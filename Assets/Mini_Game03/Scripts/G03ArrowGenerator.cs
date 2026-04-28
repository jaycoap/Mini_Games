using UnityEngine;

public class G03ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0;



    void Update()
    {
        delta += Time.deltaTime;
        Debug.Log(delta);
        if(delta > span)
        {
            delta = 0;
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-7, 8);
            go.transform.position = new Vector2(px,7);
        }
    }
}
