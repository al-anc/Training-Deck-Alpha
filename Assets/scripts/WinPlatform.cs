using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPlatform : MonoBehaviour
{
    Scene scene;
    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player"))
        {   
            Cursor.lockState = CursorLockMode.None;
            scene = SceneManager.GetActiveScene();
            if (scene.buildIndex == 2)
            {
                var sceneTrack = GameObject.Find("SceneTracker");
                var winCon = sceneTrack.GetComponent<sceneTracker>();
                winCon.Level1Completed = 1;
            }
            else if (scene.buildIndex == 3)
            {
                var sceneTrack = GameObject.Find("SceneTracker");
                var winCon = sceneTrack.GetComponent<sceneTracker>();
                winCon.Level2Completed = 1;
            }
            else if (scene.buildIndex == 4)
            {
                var sceneTrack = GameObject.Find("SceneTracker");
                var winCon = sceneTrack.GetComponent<sceneTracker>();
                winCon.Level3Completed = 1;
            }
            SceneManager.LoadScene(6);
        }
    }
}
