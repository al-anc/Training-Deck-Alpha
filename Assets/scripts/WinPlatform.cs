using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPlatform : MonoBehaviour
{

    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player"))
        {   
            Cursor.lockState = CursorLockMode.None;
             SceneManager.LoadScene(3);
        }
    }
}
