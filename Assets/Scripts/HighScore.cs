using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
  public List<TextMeshProUGUI> levels;
  private void Start()

  {
    for (int i = 0; i < levels.Count; i++)
    {
      SetHighScore(levels[i]);
    }
  }

  private void SetHighScore(TextMeshProUGUI level)
  {
    if (PlayerPrefs.GetFloat(level.name, 0) == 0)
    {
      level.text = "";
    }
    else level.text = TimeSpan.FromSeconds(PlayerPrefs.GetFloat(level.name)).ToString("mm':'ss'.'ff");
  }
}
