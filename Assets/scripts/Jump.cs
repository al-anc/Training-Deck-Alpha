using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{ 
public Rigidbody rb;
public float jumpAmount = 10;
public float coolDown = 1;
public float coolDownTimer;
public AudioSource jumpNoise;

void Update()
{
    if(coolDownTimer > 0 )
        {
        coolDownTimer -= Time.deltaTime;
        }
    if (coolDownTimer < 0)
        {
        coolDownTimer = 0;
        }
    if ((Input.GetKeyDown(KeyCode.JoystickButton0) || Input.GetKeyDown(KeyCode.Space)) && coolDownTimer == 0)
        {
        rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
        Debug.Log("hi");
        coolDownTimer = coolDown;
        jumpNoise.Play();
        }
    }
}