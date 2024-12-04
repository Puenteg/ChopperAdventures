using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayerMinimapa : MonoBehaviour
{
    private Transform player; // Referencia al transform del jugador

    void Start()
    {
        // Busca el objeto con la etiqueta "Player"
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // Asegúrate de que el jugador no sea nulo
        if (player != null)
        {
            // Actualiza la posición del objeto para que coincida con la del jugador
            transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
        }
    }
}
