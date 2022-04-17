using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    Animator anim;
    private bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis ("Vertical");
        anim.SetFloat("Speed", move);

        if(Input.GetKeyDown(KeyCode.Space)){
            anim.SetBool("IsJumping", true);
        }

        if(Input.GetKeyUp(KeyCode.Space)){
            anim.SetBool("IsJumping", false);
        }

    }
}
