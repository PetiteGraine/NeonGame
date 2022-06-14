using UnityEngine;

public class SetCamera : MonoBehaviour
{
  public Vector3 offset = new Vector3(0f, 0f, -10f);
  public int size = 8;
  public Transform target;
  public float smoothTime = 0.25f;
  new private GameObject camera;

  private void Awake()
  {
    camera = GameObject.FindGameObjectWithTag("MainCamera");
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.CompareTag("Player"))
    {
      camera.GetComponent<CameraFollow>().offset = offset;
      camera.GetComponent<CameraFollow>().target = target;
      camera.GetComponent<CameraFollow>().smoothTime = smoothTime;
      camera.GetComponent<Camera>().orthographicSize = size;
    }
  }
}
