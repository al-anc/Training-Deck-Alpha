using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    Animator anim;
    private bool isJumping;
    private bool IsCrouching;
    private bool crouched = false;
    public int isWalking = 0;
    public int isStrafing = 0;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //
        float horizontal = Input.GetAxisRaw("MoveHorizontal");
        float vertical = Input.GetAxisRaw("MoveVertical");
        //Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        if (horizontal > 0.15f){
            isStrafing = 1;
        }
        else if (horizontal < -0.15f){
            isStrafing = -1;
        }
        else{
            isStrafing = 0;
        }

        if(vertical > 0.15f){
            isWalking = 1;
        }
        else if (vertical < -0.15f){
            isWalking = -1;
        }
        else
        {
            isWalking = 0;
        }
        //

        if(Input.GetKeyDown(KeyCode.W) || isWalking == 1){
            anim.SetInteger("ZSpeed", 1);
        }
        else if (Input.GetKeyDown(KeyCode.S) || isWalking == -1){
            anim.SetInteger("ZSpeed", -1);
        }
        else if (Input.GetKeyUp(KeyCode.W) || isWalking == 0){
            anim.SetInteger("ZSpeed", 0);
        }
        else if (Input.GetKeyUp(KeyCode.S) || isWalking == 0 ){
            anim.SetInteger("ZSpeed", 0);
        }

        if (Input.GetKeyDown(KeyCode.A) || isStrafing == -1){
            anim.SetInteger("XSpeed", -1);
        }
        else if(Input.GetKeyUp(KeyCode.A) || isStrafing == 0){
            anim.SetInteger("XSpeed", 0);
        }
        else if (Input.GetKeyDown(KeyCode.D) || isStrafing == 1){
            anim.SetInteger("XSpeed", 1);
        }
        else if(Input.GetKeyUp(KeyCode.D) || isStrafing == 0){
            anim.SetInteger("XSpeed", 0);
        }
        

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.JoystickButton0)){
            anim.SetBool("IsJumping", true);
        }

        if(Input.GetKeyUp(KeyCode.Space) || Input.GetKeyUp(KeyCode.JoystickButton0)){
            anim.SetBool("IsJumping", false);
        }

        /*if(Input.GetKeyDown(KeyCode.C)){
                anim.SetBool("IsCrouching", true);
        }

        if(Input.GetKeyUp(KeyCode.C)){
                anim.SetBool("IsCrouching", false);
        }*/
        //adapted from crouch script
        if (Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.JoystickButton8))
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
