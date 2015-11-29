using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameControl : MonoBehaviour {
	[Header ("Gestor Puntos")]
	public int puntosCaramelo;
	public Text textopuntos;
	[Header ("Gestor Objeto Clave")]
	public int objetoClave;
	public Text textoclave;
	public Animator anim;
	public Image tren;
	public Sprite trenActivo, trenInactivo;
	public Puerta scriptPuerta;
	void Awake()
	{
		if (!PlayerPrefs.HasKey ("puntosCaramelo"))
		{
			PlayerPrefs.SetInt("puntosCaramelo",0);
		}
		if (!PlayerPrefs.HasKey("objetoClave"))
		{
			PlayerPrefs.SetInt("objetoClave",0);
		}

		puntosCaramelo = PlayerPrefs.GetInt ("puntosCaramelo");
		objetoClave = PlayerPrefs.GetInt ("objetoClave");
		
		//anim =GameObject.Find ("ImagenTren").GetComponent<Image>();
	}
	
	public void Da_Puntos(int puntos)
	{
		puntosCaramelo += puntos;
		textopuntos.text = ""+puntosCaramelo;
	}
	public void Recoge_Clave(int objeto_clave)
	{
		objetoClave += objeto_clave;
		textoclave.text = ""+objetoClave;
		if (objetoClave == 1)
		{
			scriptPuerta.conseguirObjeto();
			Debug.Log ("tengo uno");
			tren.overrideSprite=trenActivo;
		}
		if (objetoClave != 1)
		{
			tren.overrideSprite= trenInactivo;
		}
	}
	void Restart()
	{
		puntosCaramelo = 0;
		PlayerPrefs.SetInt ("puntosCaramelo", puntosCaramelo);
		textopuntos.text = ""+puntosCaramelo;
	}
}
