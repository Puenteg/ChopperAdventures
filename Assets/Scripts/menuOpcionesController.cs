using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class menuOpcionesController : MonoBehaviour
{

    [SerializeField] private AudioMixer audioMixer;

    public void PantallaCompleta(bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;
    }

    public void CambiarVolumen(float volumen)
    {
        audioMixer.SetFloat("volumen", volumen);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Cerrar()
    {
        Debug.Log("Cerrando Juego...");
        Application.Quit();
    }
}
