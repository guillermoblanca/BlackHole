using UnityEngine;
using UnityEngine.UI;//usado para cargar datos en la iu
using System.Collections;

public class GameControl : MonoBehaviour {
	[Header ("Gestor Puntos")]
	public int puntosCaramelo; // coge un numero entero para puntos caramelo
	public Text textopuntos;// enlaza con el texto puntos
	[Header ("Gestor Objeto Clave")]
	public int objetoClave; // aumenta el numero de objetos claves a recoger
	public Text textoclave; // coloca el texto clave, usado casi siempre para probar que funciona
	public Image tren; // carga la imagen de la ui del tren
	public Sprite trenActivo, trenInactivo; // carga los sprites para intercambiarlos dependiendo del tipo que sea 
	public Puerta scriptPuerta; // carga el script puerta
	void Awake()
	{
		if (!PlayerPrefs.HasKey ("puntosCaramelo"))  // si no existe este valor
		{
			PlayerPrefs.SetInt("puntosCaramelo",0); // lo crea a 0
		}
		if (!PlayerPrefs.HasKey("objetoClave")) // si no existe este valor 
		{
			PlayerPrefs.SetInt("objetoClave",0); // lo crea a 0
		}

		puntosCaramelo = PlayerPrefs.GetInt ("puntosCaramelo"); 
		objetoClave = PlayerPrefs.GetInt ("objetoClave");
		
		//anim =GameObject.Find ("ImagenTren").GetComponent<Image>();
	}
	
	public void Da_Puntos(int puntos) // variables para aumentar los puntos con esta variable
	{
		puntosCaramelo += puntos; // aumenta puntos 
		textopuntos.text = ""+puntosCaramelo; // lo muestra en pantalla
	}
	public void Recoge_Clave(int objeto_clave) // para saber el numero de objetos clave
	{
		objetoClave += objeto_clave; //aumenta el numero de objetos clave
		textoclave.text = ""+objetoClave; // muestra en texto, usado en pruebas
		if (objetoClave == 1)  //igual a 1
		{
			scriptPuerta.conseguirObjeto(); // carga el script conseguir objeto 
			//Debug.Log ("tengo uno");
			tren.overrideSprite=trenActivo; // para cargar el sprite dentro de iu
		}
		if (objetoClave != 1) // si es diferente a 1 
		{
			tren.overrideSprite= trenInactivo; // carga el sprite de inactivo
		}
	}
	void Restart() // aun no se esta utilizando
	{
		puntosCaramelo = 0; // reinicia 
		PlayerPrefs.SetInt ("puntosCaramelo", puntosCaramelo); // reinicia los valores
		textopuntos.text = ""+puntosCaramelo; // muestra en texto 
	}
}
