using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("ArenaScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
