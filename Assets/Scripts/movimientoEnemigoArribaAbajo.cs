using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoEnemigoArribaAbajo : MonoBehaviour
{
    public float altura = 3f; // Altura máxima de movimiento
    public float velocidad = 2f; // Velocidad de movimiento

    private Vector3 posicionInicial; // Posición inicial del objeto
    private float tiempo;

    private void Start()
    {
        // Guardar la posición inicial del objeto
        posicionInicial = transform.position;
    }

    private void Update()
    {
        // Calcular el movimiento vertical usando una función seno para un movimiento suave
        tiempo += Time.deltaTime * velocidad;
        float nuevaY = posicionInicial.y + Mathf.Sin(tiempo) * altura;

        // Aplicar la nueva posición al objeto
        transform.position = new Vector3(transform.position.x, nuevaY, transform.position.z);
    }
}
