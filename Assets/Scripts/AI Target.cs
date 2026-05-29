using UnityEngine;
using UnityEngine.AI;

public class AITarget : MonoBehaviour
{
    private int index;
    [SerializeField] private float indexDist = 1f;
    
    public Transform[] points;

    private NavMeshAgent agent;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(points[index].position);
        if (Vector3.Distance(transform.position, points[index].position) < indexDist)
        {
            index++;
            if (index > points.Length - 1)
            {
                index = 0;
            }
        }


    }
    private void OnDrawGizmos()
    {
        if (points.Length > 0)
        {
            for (int i = 0; i < points.Length; i++)
            {
                Gizmos.DrawWireCube(points[i].position, Vector3.one * indexDist);
            }
        }
    }
}
