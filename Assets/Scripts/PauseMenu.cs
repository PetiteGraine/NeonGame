using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
  public static bool GameIsPaused = false;
  public GameObject pauseMenuUI;

  private void Start()
  {
    Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
  }

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.R))
      Restart();
    if ((Input.GetKeyDown(KeyCode.Escape) || (Input.GetKeyDown(KeyCode.P))) && !EndLevel.levelIsFinished)
    {
      if (GameIsPaused)
      {
        Resume();
      }
      else
      {
        Pause();
      }
    }
  }

  public void Resume()
  {
    pauseMenuUI.SetActive(false);
    Time.timeScale = 1f;
    GameIsPaused = false;
    Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
  }

  void Pause()
  {
    Cursor.visible = true;
    Cursor.lockState = CursorLockMode.None;
    pauseMenuUI.SetActive(true);
    Time.timeScale = 0f;
    GameIsPaused = true;
  }

  public void Restart()
  {
    Time.timeScale = 1f;
    GameIsPaused = false;
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
  public void NextLevel()
  {
    Time.timeScale = 1f;
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }

  public void LoadMenu()
  {
    Time.timeScale = 1f;
    GameIsPaused = false;
    SceneManager.LoadScene("Menu");
  }

  public void SelectLevel()
  {
    Time.timeScale = 1f;
    GameIsPaused = false;
    SceneManager.LoadScene("SelectLevel");
  }

  public void QuitGame()
  {
    Application.Quit();
  }
}
