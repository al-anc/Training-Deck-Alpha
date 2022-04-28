using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveProjectile : MonoBehaviour
{
    public float projectileSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,3);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += transform.forward * Time.deltaTime * projectileSpeed;
    }

    void OnTriggerCollider(Collider other)
    {
        projectileSpeed = 0;
    }
}

