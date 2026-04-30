using UnityEngine.SceneManagement;
using UnityEngine;

public class G04ClearDicrector : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("GameScene04");
        }
    }
}
