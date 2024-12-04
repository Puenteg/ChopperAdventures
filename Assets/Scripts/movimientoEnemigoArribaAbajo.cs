using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoEnemigoArribaAbajo : MonoBehaviour
{
    public float altura = 3f; // Altura m�xima de movimiento
    public float velocidad = 2f; // Velocidad de movimiento

    private Vector3 posicionInicial; // Posici�n inicial del objeto
    private float tiempo;

    private void Start()
    {
        // Guardar la posici�n inicial del objeto
        posicionInicial = transform.position;
    }

    private void Update()
    {
        // Calcular el movimiento vertical usando una funci�n seno para un movimiento suave
        tiempo += Time.deltaTime * velocidad;
        float nuevaY = posicionInicial.y + Mathf.Sin(tiempo) * altura;

        // Aplicar la nueva posici�n al objeto
        transform.position = new Vector3(transform.position.x, nuevaY, transform.position.z);
    }
}
