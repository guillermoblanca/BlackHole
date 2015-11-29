using UnityEngine;
using System.Collections;

public class CargarNivel : MonoBehaviour {
	// este sera el selector de nivel
	public int nivel; // determina que nivel es y el orden que este sigue 
	public bool disponible; // determina si esta disponible en este momento
	bool pulsarW; // para pulsar el boton W
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update()
		// aqui damos la variable para que acceda con W para pasar de nivel
	{
		if (Input.GetKey (KeyCode.W)) // cuando esta presionado
		{
			pulsarW= true;
		}
		if (Input.GetKeyUp(KeyCode.W))// cuando levanta
		{
			pulsarW = false;
		}
	}
	void OnTriggerStay2D (Collider2D objeto) { // para que colisione el jugador este dentro
		if (objeto.transform.tag == "Player" && pulsarW)
		{
		switch(nivel) // para determinar los diferentes casos
		{
		case(1):
			// variable personaje y controlW
			//print ("nivel1"); // pruebas
			Application.LoadLevel("01_Azul"); // para cargar el nivel azul
			break;
		case(2):
			//print ("nivel2");
				Application.LoadLevel("02_nivelVerde_01");
			break;
			case (3):

				break;
		default:
			print ("no hay nivel, determinar el numero del orden");
			break;
		}
		}
	}
}
