using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HubLevelChanger : MonoBehaviour
{
    public bool isOne = false;
    public bool isTwo = false;
    public bool isThree = false;



    void OnTriggerEnter(Collider c)
    {
        if(c.CompareTag("Player"))
        {
            if(isOne == true)
            {
                SceneManager.LoadScene(1);
            }

            if(isTwo == true)
            {
                SceneManager.LoadScene(4);
            }

            if(isThree == true)
            {
                SceneManager.LoadScene(5);
            }
        }
    }
}
