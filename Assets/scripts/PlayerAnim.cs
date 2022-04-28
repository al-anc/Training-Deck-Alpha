using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    Animator anim;
    private bool isJumping;
    private bool IsCrouching;
    private bool crouched = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.W)){
            anim.SetInteger("ZSpeed", 1);
        }
        else if (Input.GetKeyDown(KeyCode.S)){
            anim.SetInteger("ZSpeed", -1);
        }
        else if (Input.GetKeyUp(KeyCode.W)){
            anim.SetInteger("ZSpeed", 0);
        }
        else if (Input.GetKeyUp(KeyCode.S)){
            anim.SetInteger("ZSpeed", 0);
        }
        else if (Input.GetKeyDown(KeyCode.A)){
            anim.SetInteger("XSpeed", -1);
        }
        else if(Input.GetKeyUp(KeyCode.A)){
            anim.SetInteger("XSpeed", 0);
        }
        else if (Input.GetKeyDown(KeyCode.D)){
            anim.SetInteger("XSpeed", 1);
        }
        else if(Input.GetKeyUp(KeyCode.D)){
            anim.SetInteger("XSpeed", 0);
        }
        

        if(Input.GetKeyDown(KeyCode.Space)){
            anim.SetBool("IsJumping", true);
        }

        if(Input.GetKeyUp(KeyCode.Space)){
            anim.SetBool("IsJumping", false);
        }

        /*if(Input.GetKeyDown(KeyCode.C)){
                anim.SetBool("IsCrouching", true);
        }

        if(Input.GetKeyUp(KeyCode.C)){
                anim.SetBool("IsCrouching", false);
        }*/
        //adapted from crouch script
        if (Input.GetKeyDown(KeyCode.C))
        {
            crouched = !crouched;
       
            if(crouched == true){
                anim.SetBool("IsCrouching", true);
            }

            if(!crouched)
            {
               anim.SetBool("IsCrouching", false);
            }
        }

    }
}
