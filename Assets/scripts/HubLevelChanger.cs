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
            var sceneTrack = GameObject.Find("SceneTracker");
            var winCheck = sceneTrack.GetComponent<sceneTracker>();
            if(isOne == true && winCheck.Level1Completed == 0)
            {
                SceneManager.LoadScene(2);
            }

            if(isTwo == true && winCheck.Level2Completed == 0)
            {
                SceneManager.LoadScene(3);
            }

            if(isThree == true && winCheck.Level3Completed == 0)
            {
                SceneManager.LoadScene(4);
            }
        }
    }
}
