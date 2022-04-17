using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject howtoPlayMenu;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
    }


    public void ChangeScreen(int screenValue)
    {
        if (screenValue == 0)
        {
            SceneManager.LoadScene(1);
        }
        if (screenValue == 1)
        {
            mainMenu.SetActive(false);
            howtoPlayMenu.SetActive(true);
        }


        if (screenValue == 2)
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
            SceneManager.LoadScene(6);
        }

    }

}
