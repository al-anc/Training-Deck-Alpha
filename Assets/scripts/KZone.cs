using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KZone : MonoBehaviour
{
      void OnTriggerEnter(Collider c)
        {
          if(c.CompareTag("Player"))
            //SceneManager.LoadScene(5);
            c.GetComponent<Health>().currentHealth = 0;
        }
}