using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_Changer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene(1);
        }

        if(Input.GetKeyDown(KeyCode.J))
        {
            SceneManager.LoadScene(2);
        }

        if(Input.GetKeyDown(KeyCode.K))
        {
            SceneManager.LoadScene(3);
        }

        if(Input.GetKeyDown(KeyCode.L))
        {
            SceneManager.LoadScene(4);
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
          Application.Quit();
          Debug.Log("Application End");
        }
    }
}
