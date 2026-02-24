using UnityEngine;
using UnityEngine.InputSystem;

public class DmgAtkScript : MonoBehaviour
{
    public bool HasWeapon;
    public float AtkDmg;
    public int AtkSpd;
    public float DmgGive;
    public float WeaponLength;
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
            // Physics.BoxCastAll(transform.position, 1.5f * WeaponType, Vector3.forward, out RaycastHit hitinfo, Quaternion.identity, WeaponLength)
            RaycastHit[] hits = Physics.BoxCastAll(transform.position, WeaponType, Vector3.down, Quaternion.identity, WeaponLength, Enemy);

            foreach (RaycastHit hit in hits)
            {
                if (hit.collider != null)
                {
                    
                }
            }
            //if (hits)
            //{
            //    Debug.Log("Object hit");

            //}


        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, WeaponType);
    }
    private void OnCollisionStay(Collision collision)
    {
        //Debug.Log(collision.gameObject.name);
        
    }
}
