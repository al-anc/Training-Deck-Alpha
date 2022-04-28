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
        if (Input.GetKeyDown(KeyCode.JoystickButton8) || Input.GetKeyDown(KeyCode.C))
        {
            crouched = !crouched;
       
            if(crouched == true){
                
                //body.localScale = new Vector3 (1,.5f,1);
                coll.height = 0.032f;
                coll.center = new Vector3(0, 0.015f, 0);
                //coll.Y = 0.015f;
            }

            if(!crouched)
            {
                //body.localScale = new Vector3 (1,1.0f,1);
                coll.height = 0.064f;
            
            }
        }
        
    }
}