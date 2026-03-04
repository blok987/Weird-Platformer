using UnityEngine;
using UnityEngine.InputSystem;

public class FuckedandEVILScript : MonoBehaviour
{
    // Physics.BoxCastAll(transform.position, 1.5f * WeaponType, Vector3.forward, out RaycastHit hitinfo, Quaternion.identity, WeaponLength)
    #region Movement 
    //void Update()
    //{
    //    // Takes player camera and determines player vector2 with it
    //    Vector3 direction = cam.transform.forward * Walk.y + cam.transform.right * Walk.x;
    //    direction *= MoveSpeed;
    //    direction.y = cc.linearVelocity.y;
    //    cc.linearVelocity = direction;

    //    // Takes input from WASD and determines transform rotation of the player
    //    transform.forward = new(cc.linearVelocity.x, 0, cc.linearVelocity.z);

    //    // Keeps player model facing most recent wasd input (E.g. Player press A, player stays facing local direct of A)

    //    // Hides Mouse at the centre of the screen 
    //    Cursor.lockState = CursorLockMode.Locked;
    //    Cursor.visible = false;
    //}

    //public void Move(InputAction.CallbackContext ctx)
    //{
    //    Walk = ctx.ReadValue<Vector2>();
    //}

    //public void Jump(InputAction.CallbackContext ctx)
    //{
    //    if (ctx.performed && IsGrounded)
    //    {
    //        cc.AddForce(0, JumpHeight, 0);

    //    }
    //}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Ground"))
    //    {
    //        IsGrounded = true;
    //    }
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Ground"))
    //    {
    //        IsGrounded = false;
    //    }
    //}
    #endregion movement

}
