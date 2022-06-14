using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
  public static bool levelIsFinished = false;
  public GameObject endLevelMenuUI;
  private float elapsedTime;
  private string highScore;

  private void Start()
  {
    levelIsFinished = false;
    highScore = "highScore" + SceneManager.GetActiveScene().name.Substring(SceneManager.GetActiveScene().name.Length - 2);
  }
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.CompareTag("Player"))
    {
      Cursor.visible = true;
      Cursor.lockState = CursorLockMode.None;
      Time.timeScale = 0f;
      levelIsFinished = true;
      DeathZone.deathCount = 0;
      endLevelMenuUI.SetActive(true);
      elapsedTime = GameObject.FindWithTag("GameController").GetComponent<TimerController>().elapsedTime;
      if (elapsedTime < PlayerPrefs.GetFloat(highScore, 0f))
      {
        PlayerPrefs.SetFloat(highScore, elapsedTime);
      }
      else if (PlayerPrefs.GetFloat(highScore, 0f) == 0)
      {
        PlayerPrefs.SetFloat(highScore, elapsedTime);
      }
    }

  }
}
