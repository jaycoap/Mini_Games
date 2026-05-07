using UnityEngine;
using UnityEngine.EventSystems;

public class G05BamsoniGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (IsPointerOverUI())
            {
                return;
            }

            GameObject bamsongi = Instantiate(bamsongiPrefab);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;     
            bamsongi.GetComponent<G05BamsongiController>().Shoot(worldDir.normalized * 2000);
            Debug.Log(worldDir*2000);
        }
    }

    private bool IsPointerOverUI()
    {
        if (EventSystem.current == null)
        {
            return false;
        }

        if (EventSystem.current.IsPointerOverGameObject())
        {
            return true;
        }

        for (int i = 0; i < Input.touchCount; i++)
        {
            if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(i).fingerId))
            {
                return true;
            }
        }

        return false;
    }

    public void ReturnLobby01()
    {
        LB_SceneController.LoadLobby();
    }
}
