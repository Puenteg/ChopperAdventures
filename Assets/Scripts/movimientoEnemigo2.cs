using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoEnemigo2 : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de movimiento
    public float limiteDerecha = 8f; // Límite derecho
    public float limiteIzquierda = -8f; // Límite izquierdo

    private bool moviendoDerecha = true; // Dirección inicial

    private void Update()
    {
        // Calcular el movimiento
        float movimiento = velocidad * Time.deltaTime * (moviendoDerecha ? 1 : -1);

        // Aplicar el movimiento al objeto
        transform.position += new Vector3(movimiento, 0, 0);

        // Verificar límites y cambiar dirección si es necesario
        if (transform.position.x >= limiteIzquierda)
        {
            moviendoDerecha = true; // Cambiar a izquierda
        }
        else if (transform.position.x <= limiteDerecha)
        {
            moviendoDerecha = false; // Cambiar a derecha
        }
    }
}
