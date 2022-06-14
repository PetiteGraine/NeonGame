using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
  public void PlayGame()
  {
    AutoSplitterData.State = RunState.Running;
    LoadScene.Select("SelectLevel");
  }

  public void QuitGame()
  {
    Application.Quit();
  }
}
