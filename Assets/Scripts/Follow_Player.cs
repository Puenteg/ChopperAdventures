using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    public float speed = 2f; // Velocidad de movimiento

    void Update()
    {
        // Mueve la cámara a la derecha
        Vector3 movement = new Vector3(speed * Time.deltaTime, 0, 0);
        transform.position += movement;
    }
}
