using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
  public void Select(string levelName)
  {
    SceneManager.LoadScene(levelName);

  }
}
