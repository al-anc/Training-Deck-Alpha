using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour
{
    public bool isExploding = false;
    public Vector2 sizerange = new Vector2(1.0f,1.5f);
    float starttime;
    public float explodetime = 1f;
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isExploding == true)
        {
            float frac = (Time.time - starttime) / explodetime;
            var size = Mathf.Lerp(sizerange.x,sizerange.y,frac);
            transform.localScale *= size;
            if(frac >= 1)
            {
                Debug.Log(transform.localScale);
                DamageAllInRange();
                //Debug.Break();
                Destroy(gameObject);
            }
        }
    }
    void DamageAllInRange()
    {
        SphereCollider SC = gameObject.GetComponent<SphereCollider>();

        Collider[] hitColliders = Physics.OverlapSphere(transform.position + SC.center, SC.radius);
        foreach (var coll in hitColliders)
        {
            Debug.Log(coll.name);
            var h = coll.gameObject.GetComponent<Health>();
            if(h != null)
            {
                h.Damage(3);
            }
    }
     
    
        //scale up collider 
        //damage in range
        //destroy self
    }
     void OnTriggerEnter(Collider c)
    {
        if(isExploding == true)
        {
            return;
        }
        if(c.CompareTag("PlayerWeapon")||c.CompareTag("Player")||c.CompareTag("Enemy"))
        {
            starttime = Time.time;
            isExploding = true;
            Debug.Log("exploded");
        }
    }
}