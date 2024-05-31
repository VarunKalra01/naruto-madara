using UnityEngine;
using UnityEngine.UI;

public class PauseMenuController : MonoBehaviour
{
    public GameObject pauseMenu;

    private void Start()
    {
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(false); // Ensure the pause menu is initially hidden
        }
    }

    public void ResumeGame()
    {
        Debug.Log("Resume button clicked");
        Time.timeScale = 1f;
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(false);
        }
    }

    public void PauseGame()
    {
        Debug.Log("Pause button clicked");
        Time.timeScale = 0f;
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(true);
        }
    }

    public void MainMenu()
    {
        Debug.Log("Main Menu button clicked");
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameStartScene");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 0f)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
}
