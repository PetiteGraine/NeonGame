using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelController : MonoBehaviour
{
  public TextMeshProUGUI deathCounterText;
  void Start()
  {
    deathCounterText.text = "Level " + SceneManager.GetActiveScene().name.Substring(SceneManager.GetActiveScene().name.Length - 2);
  }
}
