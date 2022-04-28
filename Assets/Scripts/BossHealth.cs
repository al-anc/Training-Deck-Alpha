using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{
    //public GameObject healthDisplay;
    public GameObject Boss;
    public GameObject Level3WinPlatform;
    public GameObject HealthCrystalGroup1;
    public GameObject HealthCrystalGroup2;
    public GameObject HealthCrystalGroup3;
    public int currentHealth = 10;
    public int maxHealth = 10;
    public bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        Level3WinPlatform.SetActive(false);
        Boss.transform.position = new Vector3(0, 0.24f, 0);
        currentHealth = maxHealth;
        //healthDisplay.GetComponent<Text>().text = "Health = " + currentHealth;
    }

    void Update()
    {
        
        //healthDisplay.GetComponent<Text>().text = "Health = " + currentHealth;
        if(isDead == true){
            Level3WinPlatform.SetActive(true);
            Destroy(gameObject);
        }

        var Terminal1 = GameObject.Find("Terminal1");
        var checkpoint1 = Terminal1.GetComponent<TerminalHealth>();

        var Terminal2 = GameObject.Find("Terminal2");
        var checkpoint2 = Terminal2.GetComponent<TerminalHealth>();

        var Terminal3 = GameObject.Find("Terminal3");
        var checkpoint3 = Terminal3.GetComponent<TerminalHealth>();


        if(checkpoint1.terminal1 == 1 && checkpoint2.terminal2 == 0 && checkpoint3.terminal3 == 0){
            Boss.transform.position = new Vector3(0, 1.450f, 0);
            HealthCrystalGroup1.SetActive(true);
        }
        else if(checkpoint1.terminal1 == 1 && checkpoint2.terminal2 == 1 && checkpoint3.terminal3 == 0){
            Boss.transform.position = new Vector3(0, 3.25f, 0);
            HealthCrystalGroup2.SetActive(true);
        }
        else if(checkpoint1.terminal1 == 1 && checkpoint2.terminal2 == 1 && checkpoint3.terminal3 == 1){
            Boss.transform.position = new Vector3(0, 0.240f, 0);
            HealthCrystalGroup3.SetActive(true);
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
        var Terminal1 = GameObject.Find("Terminal1");
        var checkpoint1 = Terminal1.GetComponent<TerminalHealth>();

        var Terminal2 = GameObject.Find("Terminal2");
        var checkpoint2 = Terminal2.GetComponent<TerminalHealth>();

        var Terminal3 = GameObject.Find("Terminal3");
        var checkpoint3 = Terminal3.GetComponent<TerminalHealth>();
        if(v.CompareTag("PlayerWeapon") && (checkpoint1.terminal1 == 1) && (checkpoint2.terminal2 == 1) && (checkpoint3.terminal3 == 1))
        {
            Debug.Log("Ow");
            Damage(1);
        }
    }
}

