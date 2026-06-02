
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AITarget : MonoBehaviour
{
    private int index;

    [SerializeField] private float indexDist = 1f;
    public float sightRange = 10f;

    public Transform[] points;
    [SerializeField] RaycastHit LineOfSight;
    [SerializeField] LayerMask NotPlayer;
    private NavMeshAgent agent;

    [SerializeField] GameObject Player;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {

        //Line of Sight With DotProduct
        var distance = Vector3.Distance(transform.position, Player.transform.position);
        var isInRange = distance < sightRange;
        var hitObstacle = Physics.Linecast(transform.position, Player.transform.position, out LineOfSight, NotPlayer);

        Debug.Log("Distance: " + distance);

        if (LineOfSight.collider != null)
        {
        
            Debug.Log("HitObstacle: " + LineOfSight.collider.name);

        }

        if (isInRange && !hitObstacle)
        {
            agent.SetDestination(Player.transform.position);
        }
        else
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
        //Line of Sight
        {
            Gizmos.DrawRay(transform.position, transform.forward * sightRange);
        }
    }
}
