using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buggy_Script : MonoBehaviour
{
    public float distancia = 8f; // Distancia a mover
    public float velocidad = 2f; // Velocidad de movimiento

    private Vector3 posicionInicial; // Posición inicial del objeto
    private Vector3 posicionObjetivo; // Posición objetivo

    private void Start()
    {
        // Guardar la posición inicial
        posicionInicial = transform.position;
        // Calcular la posición objetivo
        posicionObjetivo = posicionInicial + new Vector3(distancia, 0, 0);
    }

    private void Update()
    {
        // Mover el objeto hacia la posición objetivo
        transform.position = Vector3.MoveTowards(transform.position, posicionObjetivo, velocidad * Time.deltaTime);

        // Verificar si ha alcanzado la posición objetivo
        if (Vector3.Distance(transform.position, posicionObjetivo) < 0.01f)
        {
            // Detener el movimiento al alcanzar la distancia deseada
            // Puedes desactivar el script si no deseas que se mueva más
            this.enabled = false; // Desactiva el script
        }
    }
}
