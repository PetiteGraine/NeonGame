using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SliderVolume : MonoBehaviour
{
  public AudioMixer audioMixer;
  [SerializeField] private Slider slider;
  [SerializeField] private string volumeTypeName;

  void Awake()
  {
    audioMixer.SetFloat(volumeTypeName, PlayerPrefs.GetFloat(volumeTypeName, 0));
    slider.value = PlayerPrefs.GetFloat(volumeTypeName, 0);
  }

  public void SetVolume(float volume)
  {
    audioMixer.SetFloat(volumeTypeName, volume);
    PlayerPrefs.SetFloat(volumeTypeName, volume);
  }
}
