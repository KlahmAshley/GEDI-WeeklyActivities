using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class PlayerControllerSideOn : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    public float speed = 8f;
    public float jumpingPower = 16f;
    private bool isFacingRight = true;
    private bool isJumping;
    private float jumpTimeCounter;
    public float jumpTime;

   // public Animator animator;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask Floor;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.linearVelocity = Vector2.up * jumpingPower;
        }

        if (horizontal != 0f)
        {
          //  animator.SetBool("isWalking", true);
        }
        if (horizontal == 0f)
        {
          //  animator.SetBool("isWalking", false);
         //   animator.SetBool("isRunning", false);
         //   animator.SetBool("hasJumped", false);
        }

        Flip();

        if (horizontal != 0f)
        {
       //     animator.SetBool("IsWalking", true);
        }

        if (horizontal == 0f)
        {
           // animator.SetBool("IsWalking", false);
        }

    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);
    }

    private bool IsGrounded()
    {
        // Debug.Log("HitGround");
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, Floor);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

}


