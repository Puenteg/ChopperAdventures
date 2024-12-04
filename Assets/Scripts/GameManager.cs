using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public List<Personajes> personajes;

	public static GameManager Instance { get; private set; }

	public HUD hud;

	public int PuntosTotales { get; private set; }

	private int vidas = 3;

	private void Awake()
	{
		if (GameManager.Instance == null)
		{
			GameManager.Instance = this;
			DontDestroyOnLoad(this.gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}

	public void SumarPuntos(int puntosASumar)
	{
		PuntosTotales += puntosASumar;
		hud.ActualizarPuntos(PuntosTotales);
	}

	public void PerderVida()
	{
		/*
		vidas -= 1;

		if (vidas == 0)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}

		hud.DesactivarVida(vidas);
		*/
		vidas -= 1;

		if (vidas <= 0)
		{
			ReiniciarJuego(); // Reiniciar puntos y vidas
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reiniciar la escena actual
		}
		else
		{
			hud.DesactivarVida(vidas); // Desactivar la vida en el HUD
		}
	}

	public bool RecuperarVida()
	{
		if (vidas == 3)
		{
			return false;
		}

		hud.ActivarVida(vidas);
		vidas += 1;
		return true;
	}

	public void ReiniciarJuego()
	{
		PuntosTotales = 0; // Reiniciar puntos
		hud.ActualizarPuntos(PuntosTotales); // Actualizar HUD para mostrar puntos reiniciados

		vidas = 3; // Reiniciar vidas
		if (hud.vidas != null) // Verificar que el array de vidas no sea null
		{
			for (int i = 0; i < hud.vidas.Length; i++)
			{
				if (hud.vidas[i] != null) // Verificar que cada objeto de vida no sea null
				{
					hud.ActivarVida(i); // Activar todas las vidas en el HUD
				}
			}
		}
		else
		{
			Debug.LogError("El array de vidas en HUD es null.");
		}
	}
}
