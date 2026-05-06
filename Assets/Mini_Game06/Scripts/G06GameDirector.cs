using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class G06GameDirector : MonoBehaviour
{
    GameObject timeText;
    GameObject pointText;
    float time = 60.0f;
    int point = 0;

    void Start()
    {
        timeText = GameObject.Find("Time");
        pointText = GameObject.Find("Point");
    }

    void Update()
    {
        time -= Time.deltaTime;
        timeText.GetComponent<TextMeshProUGUI>().text = time.ToString("F1");
        pointText.GetComponent<TextMeshProUGUI>().text = point.ToString() + " point";
    }

    public void GetApple()
    {
        point += 100;
    }

    public void GetBomb()
    {
        point /= 2;
    }
}
