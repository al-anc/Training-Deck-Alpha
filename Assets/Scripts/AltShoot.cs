using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltShoot : MonoBehaviour
{
    public GameObject player; 
    public GameObject projectilePrefab;
    public bool canShoot = true;
    public float shootTime = 1;
    public Transform eeeee;
    // Start is called before the first frame update

    void CanShootAgain()
    {
        canShoot = true;
    }
    
    // Update is calltheed once per frame
    void Update()
    {
         if((Input.GetKeyDown(KeyCode.G) && canShoot == true) || Input.GetButtonDown("Fire2") && canShoot == true)
       {
          Instantiate(projectilePrefab, eeeee.position, transform.rotation);
        //instantiate bullet transform.lookatplayer transform.look at first 
        Debug.Log("pew");
        canShoot = false;
        Invoke("CanShootAgain",shootTime);
       }
        if(canShoot == false)
        {
            return;
        }
        
    }
    
}

