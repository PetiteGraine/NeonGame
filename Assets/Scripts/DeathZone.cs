using UnityEngine;
using UnityEngine.Audio;

public class DeathZone : MonoBehaviour
{
  private Transform playerSpawn;
  public static int deathCount = 0;
  private GameObject deathCounterText;
  [SerializeField] private AudioSource sound;

  private void Awake()
  {
    playerSpawn = GameObject.FindGameObjectWithTag("PlayerSpawn").transform;
    deathCounterText = GameObject.FindGameObjectWithTag("GameController");
  }

  private void Start()
  {
    deathCount = 0;
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.CompareTag("Player"))
    {
      collision.transform.position = playerSpawn.position;
      deathCount++;
      deathCounterText.GetComponent<DeathCountController>().deathCounterText.text = "Death count:\n" + deathCount.ToString();
      sound.Play();
    }
  }
}