using UnityEngine;
using UnityEngine.SceneManagement;

public class LB_SceneController : MonoBehaviour
{
    public void ChangeSceneLP()
    {
        SceneManager.LoadScene("GameScene01");
    }
    public void ChangeSceneCar()
    {
        SceneManager.LoadScene("GameScene02");
    }
    public void ChangeSceneMoving()
    {
        SceneManager.LoadScene("GameScene03");
    }
    public void ChangeSceneOnly()
    {
        SceneManager.LoadScene("GameScene04");
    }
    public void ChangeSceneBamsongi()
    {
        SceneManager.LoadScene("GameScene05");
    }
    public void ChangeSceneApple()
    {
        SceneManager.LoadScene("GameScene06");
    }

    public static void LoadLobby()
    {
        SceneManager.LoadScene("LobbyScene");
    }
}
