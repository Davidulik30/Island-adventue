using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_basics : MonoBehaviour
{
    public Character_Controller controller;
    public Animator MarshiAnimator;
    public float runSpeed=40f;
    
    bool jump = false;
    float horizontalMove;
    
    void Update()
    {
       horizontalMove = Input.GetAxis("Horizontal") *runSpeed;

        MarshiAnimator.SetFloat("Speed",Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
           
        }
    }
     void FixedUpdate()
    {
        controller.Move(horizontalMove*Time.deltaTime, false, jump);
        jump = false;
        
    }
}
