using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KZone : MonoBehaviour
{
      void OnTriggerEnter(Collider other)
        {
          Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(2);
            
        }
}
