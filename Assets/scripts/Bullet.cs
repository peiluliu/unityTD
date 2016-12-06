using UnityEngine;


public class Bullet : MonoBehaviour
{

    private Transform target;
    public float speed = 200f;
    public GameObject impactEffect;
    private GameObject TargetObejct;
    public int damagePerShot = 10;
    EnemyHealth enemyHealth = null;

    public void Seek(Transform _target, EnemyHealth _enemyHealth)
    {
        target = _target;
        TargetObejct = target.gameObject;
        enemyHealth = _enemyHealth;
    }

    // Update is called once per frame
    void Update()
    {

        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        transform.LookAt(target);

    }

    void HitTarget()
    {
        
        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(damagePerShot);
            Destroy(gameObject);
        }

        
        if (enemyHealth.GetisDead())
        {
            GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(effectIns, 2f);
            Destroy(target.gameObject);
            Destroy(gameObject);
        }
    }
}