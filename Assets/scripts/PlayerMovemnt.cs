using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemnt : MonoBehaviour
{
    public  player controller;

    float horizontaMove = 0f;

    public float runspeed = 40f;
    bool jump = false;
    bool Crouch = false;

    // Update is called once per frame
    void Update()
    {
        horizontaMove = Input.GetAxisRaw("Horizontal")*runspeed ;
        
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("crouch"))
        {
            Crouch = true; 

        }else if (Input.GetButtonUp("crouch"))
            {
            Crouch = false; 
            }
    }

    void FixedUpdate()
    {
        controller.Move( horizontaMove*Time.fixedDeltaTime , Crouch, jump);
        jump = false;  
    }
}
