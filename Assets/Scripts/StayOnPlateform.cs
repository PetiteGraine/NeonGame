using UnityEngine;


public class StayOnPlateform : MonoBehaviour
{

  private void OnCollisionEnter2D(Collision2D collision)
  {
    collision.transform.SetParent(transform);
  }

  private void OnCollisionExit2D(Collision2D collision)
  {
    collision.transform.SetParent(null);
  }
}
