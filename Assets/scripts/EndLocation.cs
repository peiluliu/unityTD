using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class EndLocation : MonoBehaviour {

    GameObject Enemy;
    public static PlayerHealth player;
    public static int count = 20;

    void Awake()
    {
        Enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    void OnTriggerEnter(Collider other)
    {

        //playerState.Lives = count;


        // return;
        //player.TakeDamage(2);
        Debug.Log("Working1");
        
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other);
            count -= 1;
            Debug.Log("Working2");
            
            return;
            
            
        }

        if (count <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
