using UnityEngine;

public class Teleporter : MonoBehaviour
{
  [SerializeField] private Transform teleporter;

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.CompareTag("Player"))
    {
      collision.transform.position = teleporter.position;
    }
  }
}