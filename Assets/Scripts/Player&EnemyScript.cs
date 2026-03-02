using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class StatsScript : MonoBehaviour
{
    //Character Stats
    public int StatsHealthLvL;
    //MIN-MAX Health Stats
    public float MaxHealth;
    public bool AtMaxHealth;
    public bool AtMinHealth;
    //NPC-Or-Not Stats
    public bool IsPlayer;
    public bool NotPlayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {
        if (IsPlayer == false)
        {
            Debug.Log("Not Player");
        }

        else
        {
            Debug.Log("Is Not Player");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (IsPlayer == false && AtMinHealth == true);
        //{
            
        //}
    
    }
    
}

