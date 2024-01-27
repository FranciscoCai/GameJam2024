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

        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.Play("Up");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.Play("Left");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.Play("Down");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.Play("Right");
        }
      
    }

  
}

