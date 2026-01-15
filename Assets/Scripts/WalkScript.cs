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
    private Vector2 Direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Takes player camera and determines player vector2 with it
        Vector3 direction = cam.transform.forward * Walk.y + cam.transform.right * Walk.x;
        direction *= MoveSpeed;
        direction.y = rb.linearVelocity.y;
        rb.linearVelocity = direction;
        
        // Takes input from WASD and determines transform rotation of the player
        transform.forward = new(rb.linearVelocity.x, 0, rb.linearVelocity.z);
        
        // Keeps player model facing most recent wasd input (E.g. Player press A, player stays facing local direct of A)

        // Hides Mouse at the centre of the screen 
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
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
