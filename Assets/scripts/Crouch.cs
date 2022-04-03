using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    public Transform player;
    [SerializeField] private float crouchHeight = 1.0f;
    [SerializeField] private float crouchSpeed = 5;
    [SerializeField] private float standHeight = 2f;
    private bool crouched = false;
    private float controllerHeight = 2;

    
    public float ControllerHeight
    {
        get 
        {
            if (crouched)
            {
                return crouchHeight;
            }
            else
            {
                return standHeight;
            }
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Crouch"))
        {
            crouched = !crouched;
        }
        if(crouched == true){
        controllerHeight = Mathf.Lerp(controllerHeight,ControllerHeight, crouchSpeed * Time.deltaTime);
        player.localScale = new Vector3 (1,2.5f,1);
        transform.localPosition = new Vector3 (0,2.5f,0);
        }

        if(!crouched)
        {
            player.localScale = new Vector3 (1,5,1);
        transform.localPosition = new Vector3 (0,5.38f,0);
        
        }
    }
}
