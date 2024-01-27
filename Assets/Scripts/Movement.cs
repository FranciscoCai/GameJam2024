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


        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.W))
        {
            animator.Play("Idle");
            rb.velocity = Vector2.zero;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            animator.Play("Up");
            rb.velocity = movement * moveSpeed;
        }
        
        else if (Input.GetKey(KeyCode.A))
        {
            animator.Play("Left");
            rb.velocity = movement * moveSpeed;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            animator.Play("Down");
            rb.velocity = movement * moveSpeed;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            animator.Play("Right");
            rb.velocity = movement * moveSpeed;
        }
        else
        {
            animator.Play("Idle");
            rb.velocity = Vector2.zero;
        }

    }

  
}

