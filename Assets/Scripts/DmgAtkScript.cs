using UnityEngine;
using UnityEngine.InputSystem;

public class DmgAtkScript : MonoBehaviour
{
    public float DMG;   
    public float WeaponReach;
    public Vector3 WeaponType;
    public LayerMask Enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Attack(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            //Sends out a BoxCastAll to check for enemy layer and determine whether it recieves damage
            RaycastHit[] hits = Physics.BoxCastAll(transform.position, WeaponType, Vector3.down, Quaternion.identity, WeaponReach, Enemy);

            foreach (RaycastHit hit in hits)
            {
                if (hit.collider != null)
                {
                    
                }
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, WeaponType);
    }
}
