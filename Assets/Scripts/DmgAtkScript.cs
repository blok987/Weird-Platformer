using UnityEngine;

public class DmgAtkScript : MonoBehaviour
{
    public bool hasWeapon;
    public float atkDmg;
    public int atkSpd;
    public Vector3 WeaponType;
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
}
