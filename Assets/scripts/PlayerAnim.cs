using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            animator.SetInteger("State", 1);
        }

        if(Input.GetKeyUp(KeyCode.W))
        {
            animator.SetInteger("State", 0);
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            animator.SetInteger("State", 1);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetInteger("State", 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetInteger("State", 1);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetInteger("State", 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetInteger("State", 1);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetInteger("State", 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetInteger("State", 2);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetInteger("State", 0);
        }
    }
}
