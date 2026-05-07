using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class G06GameDirector : MonoBehaviour
{
    GameObject timeText;
    GameObject pointText;
    float time = 30.0f;
    int point = 0;
    GameObject itemGenerator;

    void Start()
    {
        timeText = GameObject.Find("Time");
        pointText = GameObject.Find("Point");
        itemGenerator = GameObject.Find("G06ItemGenerator");
    }

    void Update()
    {
        GameFlow();
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

    void GameFlow()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            time = 0;
            itemGenerator.GetComponent<G06ItemGenerator>().SetParameter(10000.0f, 0, 0);
        }
        else if (0 <= time && time < 5)
        {
            itemGenerator.GetComponent<G06ItemGenerator>().SetParameter(0.9f, -0.04f, 3);
        }
        else if (5 <= time && time < 10)
        {
            itemGenerator.GetComponent<G06ItemGenerator>().SetParameter(0.4f, -0.06f, 6);
        }
        else if (10 <= time && time < 20)
        {
            itemGenerator.GetComponent<G06ItemGenerator>().SetParameter(0.7f, -0.04f, 4);
        }
        else if (20 <= time && time < 30)
        {
            itemGenerator.GetComponent<G06ItemGenerator>().SetParameter(1.0f, -0.03f, 2);
        }
    }
    public void ReturnLobby01()
    {
        LB_SceneController.LoadLobby();
    }
}
