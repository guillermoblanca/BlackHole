using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameControl : MonoBehaviour {
	[Header ("Gestor Puntos")]
	public int puntosCaramelo;
	public Text textopuntos;

	void Awake()
	{
		if (!PlayerPrefs.HasKey ("puntosCaramelo"))
		{
			PlayerPrefs.SetInt("puntosCaramelo",0);
		}

		puntosCaramelo = PlayerPrefs.GetInt ("puntosCaramelo");
	}
	
	public void Da_Puntos(int puntos)
	{
		puntosCaramelo += puntos;
		textopuntos.text = ""+puntosCaramelo;
	}
	void Restart()
	{
		puntosCaramelo = 0;
		PlayerPrefs.SetInt ("puntosCaramelo", puntosCaramelo);
		textopuntos.text = ""+puntosCaramelo;
	}
}
