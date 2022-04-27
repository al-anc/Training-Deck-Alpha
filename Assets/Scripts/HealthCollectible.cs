using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        var h = other.GetComponent<Health>();
        if(h != null)
        {
            if (h.currentHealth < h.maxHealth)
                {
                    h.Damage(-2);
                    Destroy(gameObject);
                }
        }
    }
}
