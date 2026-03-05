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
        #region Movement Inputs
        //Uses Character controller inputs to move
        if (Input.GetKey(KeyCode.W))
        {
            cc.Move(transform.forward);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            cc.Move(-transform.forward);
        }

        if (Input.GetKey(KeyCode.D))
        {
            cc.Move(transform.right);
        }

        if (Input.GetKey(KeyCode.A))
        {
            cc.Move(-transform.right);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            cc.Move(transform.up);
        }
        #endregion
    }

}
