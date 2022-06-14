using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerSkinMenu : MonoBehaviour
{
  // Colors
  private List<Color32> colors = new List<Color32>();
  private List<string> colorsText = new List<string>();
  private int index = 0; // index for the list of colors
  public static Color32 playerSkinColor = new Color32(255, 255, 255, 255); // default color : white

  // Shape
  private bool isRound;
  public static Sprite playerShape;

  // UI
  [SerializeField] TextMeshProUGUI colorText;
  [SerializeField] GameObject image;
  [SerializeField] Toggle toggle;

  void Start()
  {
    // Shape, 0 for square and 1 for circle
    if (PlayerPrefs.GetInt("isRound", 0) == 0) isRound = false;
    else if (PlayerPrefs.GetInt("isRound", 0) == 1) isRound = true;

    // Set the checkbox and correct shape
    toggle.isOn = isRound;
    image.GetComponent<Image>().sprite = playerShape;

    // Colors
    index = PlayerPrefs.GetInt("playerSkin", 0);
    colors.Add(new Color32(255, 255, 255, 255)); // White
    colorsText.Add("White");
    colors.Add(new Color32(220, 20, 60, 255)); // Crimson
    colorsText.Add("Crimson");
    colors.Add(new Color32(240, 128, 128, 255)); // LightCoral
    colorsText.Add("LightCoral");
    colors.Add(new Color32(255, 20, 147, 255)); // DeepPink
    colorsText.Add("DeepPink");
    colors.Add(new Color32(255, 192, 203, 255)); // Pink
    colorsText.Add("Pink");
    colors.Add(new Color32(255, 182, 0, 255)); // Jaune Bob
    colorsText.Add("Jaune Bob");
    colors.Add(new Color32(255, 235, 205, 255)); // BlanchedAlmond
    colorsText.Add("BlanchedAlmond");
    colors.Add(new Color32(123, 104, 238, 255)); // MediumSlateBlue
    colorsText.Add("MediumSlateBlue");
    colors.Add(new Color32(0, 250, 154, 255)); // MediumSpringGreen
    colorsText.Add("MediumSpringGreen");
    colors.Add(new Color32(152, 251, 152, 255)); // PaleGreen
    colorsText.Add("PaleGreen");
    colors.Add(new Color32(173, 255, 47, 255)); // GreenYellow
    colorsText.Add("GreenYellow");
    colors.Add(new Color32(100, 149, 237, 255)); // CornflowerBlue
    colorsText.Add("CornflowerBlue");
    colors.Add(new Color32(30, 144, 255, 255)); // DeepSkyBlue
    colorsText.Add("DodgerBlue");
    colors.Add(new Color32(106, 90, 205, 255)); // SlateBlue
    colorsText.Add("SlateBlue");
    colors.Add(new Color32(173, 216, 230, 255)); // LightBlue
    colorsText.Add("LightBlue");
    colors.Add(new Color32(119, 136, 153, 255)); // LightSlateGray
    colorsText.Add("LightSlateGray");

    // Set color
    ChangeColor();
  }

  private void ChangeColor()
  {
    colorText.text = colorsText[index];
    colorText.color = colors[index];
    image.GetComponent<Image>().color = colors[index];
    playerSkinColor = colors[index];
    PlayerPrefs.SetInt("playerSkin", index);
  }

  public void ChangeSkin()
  {
    isRound = toggle.isOn;
    if (!isRound) { playerShape = Resources.Load<Sprite>("SquareSkin"); PlayerPrefs.SetInt("isRound", 0); }
    else
    {
      playerShape = Resources.Load<Sprite>("RoundSkin"); PlayerPrefs.SetInt("isRound", 1);
    }
    image.GetComponent<Image>().sprite = playerShape;
  }

  public void MinusIndex()
  {
    if (index == 0)
      index = colors.Count - 1;
    else
      index--;
    ChangeColor();
  }

  public void PlusIndex()
  {
    if (index == colors.Count - 1)
      index = 0;
    else
      index++;
    ChangeColor();
  }
}
