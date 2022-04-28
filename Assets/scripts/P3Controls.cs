using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3Controls : MonoBehaviour
{
   //Movement
    public Transform player;
    public Transform cam;
    public float speed = .01f;
    public Transform turntable;
    public  float horizontalSpeed = 2.0f;
    public float verticalSpeed = 2.0f;
    public float dashspeed = 100.0f;
    public int isWalking = 0;
    public int isStrafing = 0;

    Animator animator;
    //public bool crouch = false;
    //pressing forward or backwards we move at the players 
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
          Application.Quit();
          Debug.Log("Application End");
        }
        //Movement

        float horizontal = Input.GetAxisRaw("MoveHorizontal");
        float vertical = Input.GetAxisRaw("MoveVertical");
        if (horizontal > 0.5f){
            isStrafing = 1;
        }
        else if (horizontal < -0.5f){
            isStrafing = -1;
        }
        else{
            isStrafing = 0;
        }

        if(vertical > 0.5f){
            isWalking = 1;
        }
        else if (vertical < -0.5f){
            isWalking = -1;
        }
        else{
            isWalking = 0;
        }
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

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
        Vector3 money = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W) || (isWalking == 1))
        {
            money += cam.forward;
        }
        if (Input.GetKey(KeyCode.S) || (isWalking == -1))
        {
            money -= cam.forward;
        }
        if (Input.GetKey(KeyCode.A) || (isStrafing == -1))
        {
            money -= cam.right;
        }
        if (Input.GetKey(KeyCode.D) || (isStrafing == 1))
        {
            money += cam.right;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            money *= (Time.deltaTime * dashspeed);
        }
        else
        {
            money *= (Time.deltaTime * speed);
        }

        /*if (Input.GetButton("Dash")) -- Disallowed ability to move WASD, commented out to fix problem.
        {
            money *= (Time.deltaTime * dashspeed);
        }
        else
        {
            money *= (Time.deltaTime * speed);
        }*/

        money.y = 0;
        turntable.position += money;
    }
}
