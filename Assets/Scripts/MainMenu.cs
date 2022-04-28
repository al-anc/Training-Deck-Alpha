using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject howtoPlayMenu;
    [SerializeField] private GameObject optionsMenu;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
    }


    public void ChangeScreen(int screenValue)
    {
        if (screenValue == 0)
        {
            SceneManager.LoadScene(6);
        }
        if (screenValue == 1)
        {
            mainMenu.SetActive(false);
            howtoPlayMenu.SetActive(true);
        }
        if (screenValue == 2)
        {
            mainMenu.SetActive(false);
            optionsMenu.SetActive(true);
        }


        if (screenValue == 5)
        {
            Debug.Log("Leave");
            Application.Quit();
        }

        if (screenValue == 3)
        {
            SceneManager.LoadScene(0);
        }

        if (screenValue == 4)
        {
            SceneManager.LoadScene(1);
        }

        if (screenValue == 7){
            var sceneTrack = GameObject.Find("SceneTracker");
            var previousScene = sceneTrack.GetComponent<sceneTracker>();
            SceneManager.LoadScene(previousScene.sceneHistory[previousScene.sceneHistory.Count-2]);
            //sceneTrack.GetComponent<sceneTracker>().sceneHistory[sceneHistory.Count-2]
        }

        if (screenValue == 8)
        {
            mainMenu.SetActive(true);
            optionsMenu.SetActive(false);
        }
    }   


}
