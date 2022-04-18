using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    //public GameObject healthDisplay;
    public GameObject projectile;
    public int currentHealth = 2;
    public int maxHealth = 2;
    public bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        //healthDisplay.GetComponent<Text>().text = "Health = " + currentHealth;
    }

    void Update()
    {
        //healthDisplay.GetComponent<Text>().text = "Health = " + currentHealth;
        if(isDead == true){
            Destroy(gameObject);
        }
    }

    public void Damage(int d) 
    {
        currentHealth -= d;
        if(currentHealth <= 0)
        {
            isDead = true;
        }
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider v)
    {
        if(v.CompareTag("Weapon"))
        {
            Debug.Log("Ow");
            Damage(1);
        }
    }
}
