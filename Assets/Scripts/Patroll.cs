using UnityEngine;

public class Patroll : MonoBehaviour
{
  [SerializeField] Transform[] waypoints;
  public float moveSpeed = 2f;
  private int waypointIndex = 0;
  void Start()
  {
    transform.position = waypoints[waypointIndex].transform.position;
  }

  void Update()
  {
    Move();
  }

  void Move()
  {
    transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);

    if (transform.position == waypoints[waypointIndex].transform.position)
      waypointIndex++;
    if (waypointIndex == waypoints.Length)
      waypointIndex = 0;
  }
}
