using UnityEngine;
using UnityEngine.Audio;

public class PlayerMovement : MonoBehaviour
{
  // Speed
  public float moveSpeed;
  public float jumpForce;
  private float horizontal;

  // Jump
  public int maxJump;
  public int remainingjump = 0;
  private bool isGrounded;

  // unity ref
  [SerializeField] private Transform groundCheck;
  public float groundCheckRadius;

  [SerializeField] private LayerMask collisionLayers;
  [SerializeField] private Rigidbody2D rb;
  [SerializeField] private AudioSource sound;

  void Update()
  {
    horizontal = Input.GetAxisRaw("Horizontal");
    if (isGrounded && !Input.GetButton("Jump"))
    {
      remainingjump = maxJump;
    }

    if (!isGrounded && remainingjump == maxJump)
    {
      remainingjump = maxJump - 1;
    }

    if (Input.GetButtonDown("Jump") && (remainingjump > 0))
    {
      rb.velocity = new Vector2(rb.velocity.x, jumpForce);
      remainingjump--;
      sound.Play();
    }

    if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
    {
      rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
    }
  }
  private void FixedUpdate()
  {
    rb.velocity = new Vector2(horizontal * (moveSpeed), rb.velocity.y);
    isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, collisionLayers);
  }

  private void OnDrawGizmos()
  {
    Gizmos.color = Color.red;
    Gizmos.DrawSphere(groundCheck.position, groundCheckRadius);
  }
}
