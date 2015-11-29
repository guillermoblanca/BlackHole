using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Puerta : MonoBehaviour {
	GameControl gc;//llama al game control 
	public bool abierto; //determina si esta abierta o no
	int objetosConseguidos; // determina cuantos objetos a conseguido
	public int objetosNecesarios; // cuantos objetos necesita
	public GameObject puerta_cerrada; // enlaza con la puerta para abrirla
	// Use this for initialization
	void Start () {
		abierto = false;
	}

	public void conseguirObjeto(){ // aumenta los puntos si coge el objeto clave
		objetosConseguidos++;
		//print ("OBJETO  CONSEGUIDO");
	}

	
	// Update is called once per frame
	void Update () { //revisa si la condicion se cumple, en tal caso ejecuta el void abrirpuerta
		if(objetosConseguidos>=objetosNecesarios){
			AbrirPuerta();

		}
	}
		void OnTriggerEnter2D (Collider2D objeto) //para que cargue el nivel principal 
		{
		if (objeto.transform.tag == "Player" && abierto)
		{
			Application.LoadLevel("00_Hall");
		}
		}
	void AbrirPuerta() 
	{
		//animacion puerta y activar el collider para cambiar el mapa 
		puerta_cerrada.SetActive(false);
		abierto = true;
		
	}
	}
