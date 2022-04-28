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
    public float dashspeed = 120.0f;
    public int isWalking = 0;
    public int isStrafing = 0;
    float v;
    float h;
    public float coolDown = 1;
    public float coolDownTimer;

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
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
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
        else
        {
            isWalking = 0;
        }

        //  player.position += front * speed; 
        //this rotates the turntable left and right
        if (Input.GetAxis("Mouse X") > 0.05f){
            h = horizontalSpeed * Input.GetAxis("Mouse X");
        }
        else if(Input.GetAxis("TurnHorizontal") > 0.01f)//replace with camera X axis for controller input.
        {
            h = horizontalSpeed * Input.GetAxis("TurnHorizontal");
        }
        else if (Input.GetAxis("Mouse X") < -0.05f){
            h = horizontalSpeed * Input.GetAxis("Mouse X");
        }
        else if(Input.GetAxis("TurnHorizontal") < -0.01f)//replace with camera X axis for controller input.
        {
            h = horizontalSpeed * Input.GetAxis("TurnHorizontal");
        }
        else if (Input.GetAxis("Mouse X") > -0.05f && Input.GetAxis("Mouse X") < 0.05f)
        {
            h = 0;
        }
        else if (Input.GetAxis("TurnHorizontal") > -0.01f && Input.GetAxis("TurnHorizontal") < 0.01f)//replace with camera X axis for controller input.
        {
            h = 0;
        }
        turntable.Rotate(0, h, 0);

        //controls camera up and down does not move player
        if (Input.GetAxis("Mouse Y") > 0.05f){
            v = verticalSpeed * Input.GetAxis("Mouse Y");
        }
        else if (Input.GetAxis("TurnVertical") > 0.01f)//replace with camera Y axis for controller input.
        {
            v = verticalSpeed * Input.GetAxis("TurnVertical");
        }
        else if (Input.GetAxis("Mouse Y") < -0.05f){
            v = verticalSpeed * Input.GetAxis("Mouse Y");
        }
        else if (Input.GetAxis("TurnVertical") < -0.01f)//replace with camera Y axis for controller input.
        {
            v = verticalSpeed * Input.GetAxis("TurnVertical");
        }
        else if (Input.GetAxis("Mouse Y") > -0.05f && Input.GetAxis("Mouse Y") < 0.05f)
        {
            v = 0;
        }
        else if (Input.GetAxis("TurnVertical") > -0.01f && Input.GetAxis("TurnVertical") < 0.01f)//replace with camera Y axis for controller input.
        {
            v = 0;
        }
        cam.Rotate(v * -1, 0, 0);
        //
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

        if(coolDownTimer > 0 )
        {
        coolDownTimer -= Time.deltaTime;
        }
        if (coolDownTimer < 0)
        {
        coolDownTimer = 0;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && coolDownTimer == 0 || Input.GetButton("Dash") && coolDownTimer == 0)
        {
            coolDownTimer = coolDown;
            money *= (Time.deltaTime * dashspeed);
            Debug.Log("Dashed");
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
