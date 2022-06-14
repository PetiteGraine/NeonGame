using UnityEngine;
using UnityEngine.Audio;
public class Checkpoint : MonoBehaviour
{
  private Transform playerSpawn;
  public SpriteRenderer graphics;
  [SerializeField] private AudioSource sound;
  private void Awake()
  {
    playerSpawn = GameObject.FindGameObjectWithTag("PlayerSpawn").transform;
  }
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.CompareTag("Player"))
    {
      playerSpawn.position = transform.position;
      gameObject.GetComponent<BoxCollider2D>().enabled = false;
      graphics.sprite = Resources.Load<Sprite>("Checkpoint");
      sound.Play();
    }
  }
}