using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_chopper : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento del jugador
    public AudioSource footstepSound;
    private Rigidbody2D rb; // Referencia al componente Rigidbody2D
    private Vector2 movement; // Vector para almacenar el movimiento

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtener el componente Rigidbody2D
    }

    void Update()
    {
        // Obtener el movimiento horizontal y vertical
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Crear un vector de movimiento
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        // Mover al jugador
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        // Fijar la rotación
        transform.rotation = Quaternion.identity;

        // Reproducir o detener el sonido de pasos
        if (movement.magnitude > 0f) // Comprobar si hay movimiento
        {
            if (!footstepSound.isPlaying)
            {
                footstepSound.Play();
            }
        }
        else
        {
            if (footstepSound.isPlaying)
            {
                footstepSound.Stop();
            }
        }
        /*
        // Capturar la entrada del jugador
        float movement = Input.GetAxis("Horizontal");
        float movement.y = Input.GetAxisRaw("Vertical");

        // Reproducir o detener el sonido de pasos
        if (movement != 0)
        {
            if (!footstepSound.isPlaying)
            {
                footstepSound.Play();
            }
        }
        else
        {
            if (footstepSound.isPlaying)
            {
                footstepSound.Stop();
            }
        }
        */


    }

    void FixedUpdate()
    {
        // Mover el jugador
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Detectar colisiones con otros objetos
        if (collision.gameObject.CompareTag("Obstacle")) // Cambia "Obstacle" por la etiqueta que quieras usar
        {
            Debug.Log("Colisionó con: " + collision.gameObject.name);
            // Aquí puedes agregar acciones adicionales, como detener el movimiento o reducir la velocidad
        }
    }
}
