using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    public int start = 2;
    public int current = 2;
    public int startingHealth = 2;
    public int currentHealth = 2;
    public Slider healthSlider;
    public Image damageImage;
    public AudioClip deathClip;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    
    

    Animator anim;
    AudioSource playerAudio;
    PlayerMovement playerMovement;
    PlayerShooting playerShooting;
    bool isDead;
    public bool damaged;
    int HealthPostionAmount;

    void Start()
    {
        //start = startingHealth;
        //currentHealth = current;
    }
    void Awake ()
    {
        anim = GetComponent <Animator> ();
        playerAudio = GetComponent <AudioSource> ();
        playerMovement = GetComponent <PlayerMovement> ();
        playerShooting = GetComponentInChildren <PlayerShooting> ();
        currentHealth = startingHealth;
    }


    void Update ()
    {

        if(damaged)
        {
            damageImage.color = flashColour;
        }
        else
        {
            damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
    }


    public void TakeDamage (int amount)
    {
        SceneManager.LoadScene(2);
        damaged = true;

        //currentHealth  = currentHealth - amount;

        healthSlider.value = currentHealth;

        playerAudio.Play ();

        if(currentHealth <= 0 && !isDead)
        {
            
            Death ();
           
        }
        //SceneManager.LoadScene(2);

    }


    void Death ()
    {
        //SceneManager.LoadScene(2);
        isDead = true;

        playerShooting.DisableEffects ();

        anim.SetTrigger ("Die");

        playerAudio.clip = deathClip;
        playerAudio.Play ();

        playerMovement.enabled = false;
        playerShooting.enabled = false;
        
        
    }


    public void RestartLevel ()
    {
        SceneManager.LoadScene (0);
    }


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("HealthPotion"))
        {
            HealthPostionAmount = 50;
            other.gameObject.SetActive(false);
            currentHealth += HealthPostionAmount;
            healthSlider.value = currentHealth;
        }
    }
}
