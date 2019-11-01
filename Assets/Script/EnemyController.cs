using UnityEngine;
using UnityEngine.AI;
public class EnemyController : MonoBehaviour
{
    public float check_radius = 10f;
    Transform target;

    public GameObject player;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerManager>().instance.player.transform;
        agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(target.position, transform.position);
        if(dist < check_radius){
            agent.SetDestination(target.position);
        }
    }

    void OnDrawGizmosSelected() {
        Gizmos.color  = Color.red;
        Gizmos.DrawWireSphere(transform.position, check_radius);
    }
}
