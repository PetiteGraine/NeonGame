using UnityEngine;
using TMPro;

public class DeathCountController : MonoBehaviour
{
  public TextMeshProUGUI deathCounterText;

  void Start()
  {
    deathCounterText.text = "Death count:\n0";
  }
}
