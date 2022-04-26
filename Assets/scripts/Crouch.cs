using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    public CapsuleCollider coll;
    public Transform body;
    private bool crouched = false;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Crouch"))
        {
            crouched = !crouched;
       
            if(crouched == true){
                
                body.localScale = new Vector3 (1,.5f,1);
                coll.height = 1;
                                }

            if(!crouched)
            {
                body.localScale = new Vector3 (1,1.0f,1);
                coll.height = 2;
            
            }
        }
        
    }
}