using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPausa : MonoBehaviour
{

    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausar;

    public void Pausa()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausar.SetActive(true);

    }

    public void Reanudar()
    {
        Debug.Log("Juego reanudado");
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausar.SetActive(false);

    }

    public void Riniciar()
    {
        Debug.Log("Juego reiniciado");
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Cerrar()
    {
        Debug.Log("Cerrando Juego...");
        Application.Quit();
    }
}
