using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
	public GameManager gameManager;
	public TextMeshProUGUI puntos;
	public GameObject[] vidas;

	void Update()
	{
		puntos.text = GameManager.Instance.PuntosTotales.ToString();
	}

	public void ActualizarPuntos(int puntosTotales)
	{
		puntos.text = puntosTotales.ToString();
	}

	/*
	public void DesactivarVida(int indice)
	{
		vidas[indice].SetActive(false);
	}
	*/
	public void DesactivarVida(int indice)
	{
		// Verificar si el �ndice es v�lido y si el objeto de vida a�n existe
		if (indice >= 0 && indice < vidas.Length && vidas[indice] != null)
		{
			vidas[indice].SetActive(false);
		}
		else
		{
			Debug.LogWarning("�ndice de vida fuera de rango o el objeto ya ha sido destruido: " + indice);
		}
	}

	public void ActivarVida(int indice)
	{
		/*
		vidas[indice].SetActive(true);
		*/
		// Verificar si el �ndice es v�lido y si el objeto de vida a�n existe
		if (indice >= 0 && indice < vidas.Length && vidas[indice] != null)
		{
			vidas[indice].SetActive(true);
		}
		else
		{
			Debug.LogWarning("�ndice de vida fuera de rango o el objeto ya ha sido destruido: " + indice);
		}
	}
}
