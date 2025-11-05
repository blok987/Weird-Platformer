using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class WalkScript : MonoBehaviour
{
    public Rigidbody rb;
    public float JumpHeight;
    public float MoveSpeed;

    private Vector2 Movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector3(Movement.x * MoveSpeed, rb.linearVelocity.y, Movement.y * MoveSpeed);
    }

    public void Move(InputAction.CallbackContext ctx)
    {
        Movement = ctx.ReadValue<Vector2>();
    }

    public void Jump(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            rb.AddForce(0, JumpHeight, 0);

        }
    }

}
