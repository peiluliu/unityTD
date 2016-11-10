using UnityEngine;
using System.Collections;

public class FriendlyEnemyMovement : MonoBehaviour {

    /*
    Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    NavMeshAgent nav;

    Vector3 movement;
    Transform Enemy;
    Rigidbody EnemyRigidbody;
    private float speed = 1f;
    private float distance;

    float timeCounter = 0;
    float radius = 6f;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>();

        Enemy = GetComponent<Transform>().transform;
        EnemyRigidbody = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        distance = Vector3.Distance(transform.position, player.position);
        if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        {
            if (distance > radius)
            {
                nav.SetDestination(player.position);
            }
            else
            {
                nav.SetDestination(transform.position);
                timeCounter += Time.deltaTime;

                float x = player.position.x + radius * Mathf.Sin(timeCounter);
                float y = transform.position.y;
                float z = player.position.z + radius * Mathf.Cos(timeCounter);

                nav.SetDestination(new Vector3(x, y, z));
            }
        }
        else
        {
            nav.enabled = false;
        } 
    }
    */
}

