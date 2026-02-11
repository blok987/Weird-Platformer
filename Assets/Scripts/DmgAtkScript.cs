using UnityEngine;

public class DmgAtkScript : MonoBehaviour
{
    public bool HasWeapon;
    public float AtkDmg;
    public int AtkSpd;
    public Vector3 WeaponType;
    public bool DmgGive;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, WeaponType);
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
        //OnCollisionStay
    }

}
