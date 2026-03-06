using Unity.Android.Gradle.Manifest;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class WalkScript : MonoBehaviour
{

    public CharacterController cc;
    public Camera cam;
    
    public float JumpHeight;
    public float MoveSpeed = 5;
    public float SprintSpeed;

    [SerializeField] private bool IsGrounded;
    [SerializeField] private bool IsSprint;
    [SerializeField] private int Sprint;
    [SerializeField] private float gravity = -9.8f;

    private Vector3 Walk;
    private Vector3 DirectionInp;
    private float YVelocity;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        YVelocity += gravity * Time.deltaTime;

        Vector3 CameraRotation = Camera.main.transform.forward;
        CameraRotation.y  = 0;
        transform.forward = CameraRotation;

        Vector3 Movement = default;

        #region Movement Inputs
        //Uses Character controller inputs to move
        if (Input.GetKey(KeyCode.W))
        {
            Movement += transform.forward.normalized * MoveSpeed;
            
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            Movement += -transform.forward.normalized * MoveSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Movement += transform.right.normalized * MoveSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Movement += -transform.right.normalized * MoveSpeed;
        }

        Movement.y = 0;

        if (Input.GetKeyDown(KeyCode.Space)&& IsGrounded)
        {
            YVelocity = JumpHeight;
            IsGrounded = false;
        }
        IsGrounded = true;
        cc.Move(Movement + Vector3.up * YVelocity * Time.deltaTime);
        #endregion
    }

}
