using UnityEngine;
using UnityEngine.InputSystem;

public class DmgAtkScript : MonoBehaviour
{
    public bool HasWeapon;
    public float AtkDmg;
    public int AtkSpd;
    public Vector3 WeaponType;
    public bool DmgGive;
    public LayerMask Enemylayer;
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
            Debug.Log("attack");

            if (Physics.BoxCast(transform.position, WeaponType, Vector3.up, out RaycastHit hitinfo, Quaternion.identity, 1, Enemylayer))
            {
                //hitinfo.collider.gameObject
                Debug.Log("Object Hit:" + hitinfo.collider.name);
            }


        }

    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, WeaponType);
    }
}
