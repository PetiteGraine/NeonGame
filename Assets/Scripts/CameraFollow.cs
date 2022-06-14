using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  public Vector3 offset = new Vector3(5f, 0f, -10f);
  public float smoothTime = 0.25f;
  private Vector3 velocity = Vector3.zero;

  public Transform target;

  void Update()
  {
    Vector3 targetPosition = target.position + offset;
    transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
  }
}
