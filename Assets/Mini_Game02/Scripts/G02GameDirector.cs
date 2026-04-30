using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class G02GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    void Start()
    {
        car = GameObject.Find("car_0");
        flag = GameObject.Find("flag_0");
        distance = GameObject.Find("Distance");    
    }

    void Update()
    {
        float length = flag.transform.position.x - car.transform.position.x;
        if (length >= 0)
        {
            distance.GetComponent<TextMeshProUGUI>().text = "distance" + length.ToString("F2") + "m";
        }
        else
        {
            distance.GetComponent<TextMeshProUGUI>().text = "GameOver";
        }
    }
    public void ReturnLobby02()
    {
        LB_SceneController.LoadLobby();
    }
}
