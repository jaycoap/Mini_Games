using UnityEngine;

public class G06ItemGenerator : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bombPrefab;
    float span = 1.0f;
    float delta = 0;
    int ratio = 2;
    float speed = -0.03f;

    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject Item;
            int dice = Random.Range(1, 11);
            if (dice <= ratio)
            {
                Item = Instantiate(bombPrefab);
            }
            else
            {
                Item = Instantiate(applePrefab);
            }
            float x = Random.Range(-1, 2);
            float z = Random.Range(-1, 2);
            Item.transform.position = new Vector3(x, 4, z);
            Item.GetComponent<G06ItemController>().dropSpeed = speed;
        }
    }

    public void SetParameter(float span, float speed, int ratio)
    {
        span = span;
        ratio = ratio;
        speed = speed;
    }
}
