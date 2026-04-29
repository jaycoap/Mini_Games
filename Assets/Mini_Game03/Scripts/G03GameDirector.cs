using UnityEngine;
using UnityEngine.UI;

public class G03GameDirector : MonoBehaviour
{
    GameObject hp_Gauge;
    void Start()
    {
        hp_Gauge = GameObject.Find("HpGauge");               
    }
    public void DecreaseHp()
    {
        hp_Gauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
