using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public GameObject healthDisplay;
    public int currentHealth = 5;
    public int maxHealth = 5;
    public bool isDead = false;
    public int sceneDeath;
    Scene scene;
    // Start is called before the first frame update
    void Start()
    {
        var sceneTrack = GameObject.Find("SceneTracker");
        var difficultyTracker = sceneTrack.GetComponent<sceneTracker>();
        if(difficultyTracker.EasyDifficulty){
            maxHealth = 10;
        }
        else if(difficultyTracker.MedDifficulty){
            maxHealth = 5;
        }
        else if(difficultyTracker.HardDifficulty){
            maxHealth = 3;
        }
        currentHealth = maxHealth;
        healthDisplay.GetComponent<Text>().text = "Health = " + currentHealth;
    }

    void Update()
    {
        var sceneTrack = GameObject.Find("SceneTracker");
        var invincibilityCheck = sceneTrack.GetComponent<sceneTracker>();
        healthDisplay.GetComponent<Text>().text = "Health = " + currentHealth;
        if(currentHealth <= 0 && !invincibilityCheck.invincible){
            isDead = true;
            //scene = SceneManager.GetActiveScene();
            //sceneDeath = scene.buildIndex;
            //Debug.Log(sceneDeath);
            SceneManager.LoadScene(5);
        }
    }

    public void Damage(int d) 
    {
        var sceneTrack = GameObject.Find("SceneTracker");
        var invincibilityCheck = sceneTrack.GetComponent<sceneTracker>();
        if (!invincibilityCheck.invincible)
        {
            currentHealth -= d;
        }
        /*if(currentHealth <= 0)
        {
            isDead = true;
            scene = SceneManager.GetActiveScene();
            sceneDeath = scene.buildIndex;
            Debug.Log(sceneDeath);
            SceneManager.LoadScene(5);
        }*/
        if (currentHealth > maxHealth){
            currentHealth = maxHealth;
        }
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider c)
    {
        if(c.CompareTag("Weapon") || c.CompareTag("BossWeapon"))
        {
            Debug.Log("Ow");
            Damage(1);
        }
    }
}
