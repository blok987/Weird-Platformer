
using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class WalkScript : MonoBehaviour
{

    public CharacterController cc;
    public Camera cam;
    public int CameraFOV = 80;

    public float JumpHeight;
    public float MoveSpeed = 5;
    public float SprintSpeed;

    [SerializeField] private bool IsGrounded;
    [SerializeField] private bool IsSprint;
    [SerializeField] private int Sprint;
    [SerializeField] private float gravity = -9.8f;
    [SerializeField] private CinemachineOrbitalFollow OrbFollow; 

    private Vector3 Walk;
    private Vector3 DirectionInp;
    private Vector3 Lookdirection;
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

  

        Vector3 Movement = default;

        #region Movement Inputs
        //Uses Character controller inputs to move
       
        //player sprinting and forward strafe
        if (Input.GetKey(KeyCode.W) && (Input.GetKey(KeyCode.LeftShift)))
        {
            Movement += Camera.main.transform.forward * SprintSpeed * Time.deltaTime;
            Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, CameraFOV + 60, Time.deltaTime * 5);

        }
        else if (Input.GetKey(KeyCode.W))
        {
            Movement += Camera.main.transform.forward * MoveSpeed * Time.deltaTime;
            Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, CameraFOV, Time.deltaTime * 5);
        }
        
        //strafe back
        if (Input.GetKey(KeyCode.S))
        {
            Movement -= Camera.main.transform.forward * MoveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Movement += Camera.main.transform.right * MoveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Movement -= Camera.main.transform.right * MoveSpeed * Time.deltaTime;
        }

        Movement.y = 0;

        if (Input.GetKeyDown(KeyCode.Space)&& IsGrounded)
        {
            YVelocity = JumpHeight;
            IsGrounded = false;
        }
        
        if (Input.GetMouseButton(1))
        {
            Vector3 CameraRotation = Camera.main.transform.forward;
            CameraRotation.y = 0;
            Lookdirection = CameraRotation;
        }
        else if (Movement.magnitude > 0)
        {
            Lookdirection = Movement;
        }

        float MouseWheel = Input.GetAxis("Mouse ScrollWheel");
        if (MouseWheel != 0) 
        { 
         OrbFollow.Radius -= MouseWheel;
        }

        transform.forward = Vector3.Slerp(transform.forward, Lookdirection, Time.deltaTime * 10);

        IsGrounded = true;
        
        cc.Move(Movement + Vector3.up * YVelocity * Time.deltaTime);
        #endregion

    }

}