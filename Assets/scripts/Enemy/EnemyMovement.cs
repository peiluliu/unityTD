using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    /*
    //Transform player;
    //PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    NavMeshAgent nav;
    */
    public float speed = 10f;
    private Transform target;
    private int wavepointIndex = 0;

    // Use this for initialization
    void Start()
    {
        target = waypoints.points[0];
    }
    /*
    void Awake ()
    {
        //player = GameObject.FindGameObjectWithTag ("Player").transform;
        //playerHealth = player.GetComponent <PlayerHealth> ();
        enemyHealth = GetComponent <EnemyHealth> ();
        nav = GetComponent <NavMeshAgent> ();
        
    }
    */
    void Update ()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        transform.rotation = Quaternion.LookRotation(dir);

        if (Vector3.Distance(transform.position, target.position) <= 1f)
        {
            GetNextWaypoint();
        }

        /*
        if (enemyHealth.currentHealth > 0)
        {
            transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        }
        else
        {
            nav.enabled = false;
        }
        */
    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        wavepointIndex++;
        target = waypoints.points[wavepointIndex];
    }
}
