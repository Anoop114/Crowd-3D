using UnityEngine;
using UnityEngine.SceneManagement;
public class GameWin : MonoBehaviour
{
    private GameObject enemys;
    public GameObject WinUi;
    void FixedUpdate()
    {
        enemys = GameObject.FindWithTag("Enemy");
        if(enemys == null)
        {
            PauseGame();
        }
    }
    void PauseGame()
    {
        Time.timeScale = 0;
        WinUi.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
    }
}
