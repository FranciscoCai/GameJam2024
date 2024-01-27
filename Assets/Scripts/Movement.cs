using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Movement : MonoBehaviour

{
    public float moveSpeed = 5f; 

    private Rigidbody2D rb;

    private Animator animator;

   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontalInput, verticalInput);

        rb.velocity = movement * moveSpeed;

        if (Input.GetKey(KeyCode.W))
        {
            animator.Play("Up");
            
        }
        
        else if (Input.GetKey(KeyCode.A))
        {
            animator.Play("Left");
            
        }

        else if (Input.GetKey(KeyCode.S))
        {
            animator.Play("Down");
            
        }

        else if (Input.GetKey(KeyCode.D))
        {
            animator.Play("Right");
            
        }
        else
        {
            animator.Play("Idle");
           
        }

    }

  
}

