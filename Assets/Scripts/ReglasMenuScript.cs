using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ReglasMenuScript : MonoBehaviour
{
    public TMP_Text displayText; // Asigna el componente TextMeshPro desde el Inspector
    public TMP_Text parrafoText;
    public Image displayImage; // Asigna el componente Image desde el Inspector
    public string[] texts; // Array de textos
    public string[] parrafo;
    public Sprite[] images; // Array de imágenes
    private int currentIndex = 0;

    void Start()
    {
        UpdateDisplay();
    }

    public void Next()
    {
        currentIndex++;
        if (currentIndex >= texts.Length)
        {
            currentIndex = 0; // Regresar al inicio
        }
        UpdateDisplay();
    }

    public void Previous()
    {
        currentIndex--;
        if (currentIndex < 0)
        {
            currentIndex = texts.Length - 1; // Ir al final
        }
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        displayText.text = texts[currentIndex];
        parrafoText.text = parrafo[currentIndex];
        displayImage.sprite = images[currentIndex];
    }
}
