using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3Controls : MonoBehaviour
{
   
public Transform player;
public Transform cam;
public float speed = .01f;
public Transform turntable;
public  float horizontalSpeed = 2.0f;
public float verticalSpeed = 2.0f;
public float dashspeed = 100.0f;
//public bool crouch = false;
//pressing forward or backwards we move at the players 
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {  
 
        

      //  player.position += front * speed; 
      //this rotates the turntable left and right
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        turntable.Rotate(0, h, 0);  
        
        //controls camera up and down does not move player
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
         cam.Rotate(v * -1, 0, 0);  
         
         //
          Vector3 front = cam.forward;
        front.y = 0;
       // turntable.position += front * speed; 
        Vector3 money = new Vector3(0,0,0);
         if(Input.GetKey(KeyCode.W)) {
             money += cam.forward; 
         }
          if(Input.GetKey(KeyCode.S)) {
             money -= cam.forward ;
         }
          if(Input.GetKey(KeyCode.A)) {
            money -= cam.right;
         }
          if(Input.GetKey(KeyCode.D)) {
             money += cam.right;
         }
         if(Input.GetKeyDown(KeyCode.LeftShift))
         {
             money *= (Time.deltaTime * dashspeed); 
         }
         else{
         money *= (Time.deltaTime * speed);
         }
         money.y = 0;
         turntable.position += money;
         //if(Input.GetKeyDown(KeyCode.C)){
           //  if(crouch == true) {
           //     crouch = false;
           //      player.localScale = new Vector3 (1,5f,1);
           //  }
          //  if(crouch == false) {
           //  crouch = true;
          //   player.localScale = new Vector3 (1,2.5f,1);
           // }
        // }


         
    }
}
