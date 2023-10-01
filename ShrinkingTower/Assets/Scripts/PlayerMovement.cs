using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    public float dashSpeed = 10f;
    public float dashDuration = 0.2f;
    private bool isGrounded = true;
    private bool isDashing = false;
    private float dashTime = 0f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       
       Movement();
        Jump();

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = true;
        }
    }
    void Movement()
    {
       
        if (Input.GetKeyDown(KeyCode.E) && !isDashing)
        {
            isDashing = true;
            dashTime = dashDuration;

            
            float dashDirection = (transform.localScale.x > 0) ? 1f : -1f;
            rb.velocity = new Vector2(dashDirection * dashSpeed, rb.velocity.y);
        }

        if (isDashing)
        {
            dashTime -= Time.deltaTime;

            if (dashTime <= 0)
            {
                isDashing = false;
            }
        }
        else
        {
            
            float moveInput = Input.GetAxis("Horizontal");
            Vector2 moveDirection = new Vector2(moveInput, 0);
            rb.velocity = new Vector2(moveDirection.x * moveSpeed, rb.velocity.y);

            
            if (moveInput > 0)
            {
                transform.localScale = new Vector3(1f, 1f, 1f);
            }
            else if (moveInput < 0)
            {
                transform.localScale = new Vector3(-1f, 1f, 1f);
            }
        }
    }
    void Jump()
    {
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }

    }

}
