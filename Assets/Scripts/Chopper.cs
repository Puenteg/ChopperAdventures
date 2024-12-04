using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    private bool isGrounded;
    private int jumpCount;

    private int maxJumpCount = 2;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpCount = 0;
    }

    void Update()
    {
        // Movimiento horizontal
        float moveInput = Input.GetAxisRaw("Horizontal");
        Vector2 moveVelocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        rb.velocity = moveVelocity;

        // Verifica si está en el suelo
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 1.1f);

        // Salto
        if (Input.GetMouseButtonDown(0) && jumpCount < maxJumpCount)
        {
            if (isGrounded || jumpCount < 1) // Permite un salto adicional
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                jumpCount++;
            }
        }

        // Reinicia el contador de saltos al tocar el suelo
        if (isGrounded)
        {
            jumpCount = 0;
        }
    }
    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce); // Aplica la fuerza de salto
        jumpCount++; // Incrementa el contador de saltos
    }
}
