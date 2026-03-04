using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class WalkScript : MonoBehaviour
{
    public CharacterController cc;
    public float JumpHeight;
    public float MoveSpeed;
    public float SprintSpeed;
    public Camera cam;
    private bool IsGrounded;
    private bool IsSprint;
    public int Sprint;
    private Vector3 Walk;
    private Vector3 DirectionInp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        if (enabled == false)
            return;

        DirectionInp = context.ReadValue<Vector2>();
        Debug.Log($"Move input: {Walk}");
    }
}
