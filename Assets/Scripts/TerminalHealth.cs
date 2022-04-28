using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TerminalHealth : MonoBehaviour
{
    //public GameObject healthDisplay;
    public int currentHealth = 3;
    public int maxHealth = 3;
    public bool isDead = false;
    public Material UncorruptedMaterial;
    public GameObject Terminal;
    public int terminal1 = 0;
    public int terminal2 = 0;
    public int terminal3 = 0;
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
            Terminal.GetComponent<MeshRenderer>().material = UncorruptedMaterial;
            if (Terminal.name == "Terminal1"){
                terminal1 = 1;
            }
            else if (Terminal.name == "Terminal2"){
                terminal2 = 1;
            }
            else if (Terminal.name == "Terminal3"){
                terminal3 = 1;
            }
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
        if(v.CompareTag("PlayerWeapon"))
        {
            Debug.Log("Decorrupted");
            Damage(1);
        }
    }
}