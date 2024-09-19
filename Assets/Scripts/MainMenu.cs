using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void pressStart()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("PlayScene");
    }
}
