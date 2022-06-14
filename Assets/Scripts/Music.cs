using UnityEngine;

public class Music : MonoBehaviour
{
  private static Music instance = null;
  void Awake()
  {
    if (instance != null && instance != this)
    {
      Destroy(gameObject);
      return;
    }
    else { instance = this; }
    DontDestroyOnLoad(gameObject);
  }
}
