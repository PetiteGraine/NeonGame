using UnityEngine;
using UnityEngine.SceneManagement;

public static class LoadScene
{
  public static void Select(string levelName)
  {
    AutoSplitterData.Level = levelName;
    AutoSplitterData.Checkpoint = 0;
    SceneManager.LoadScene(levelName);
  }
}

public class LoadSceneWrapper : MonoBehaviour
{
  public void Select(string levelName) {
    LoadScene.Select(levelName);
  }
}