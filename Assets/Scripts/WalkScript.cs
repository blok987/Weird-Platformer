using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class WalkScript : MonoBehaviour
{
    public Rigidbody rb;
    public float JumpHeight;
    public float MoveSpeed;
    public float SprintSpeed;
    public Camera cam;
    private bool IsGrounded;
    private bool IsSprint;
    public int Sprint;
    private Vector2 Walk;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // takes the local direction of the player and camera and uses 
        Vector3 direction = cam.transform.forward * Walk.y + cam.transform.right * Walk.x;
        direction *= MoveSpeed;
        direction.y = rb.linearVelocity.y;

        rb.linearVelocity = direction;
    }

    public void Move(InputAction.CallbackContext ctx)
    {
        Walk = ctx.ReadValue<Vector2>();
    }

    public void Jump(InputAction.CallbackContext ctx)
    {
        if (ctx.performed && IsGrounded)
        {
            rb.AddForce(0, JumpHeight, 0);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGrounded = true; 
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGrounded = false;
        }
    }
}
