using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Puerta : MonoBehaviour {
	GameControl gc;
	public bool abierto;
	int objetosConseguidos;
	public int objetosNecesarios;
	public GameObject puerta_cerrada;
	// Use this for initialization
	void Start () {
		abierto = false;
	}

	public void conseguirObjeto(){
		objetosConseguidos++;
		//print ("OBJETO  CONSEGUIDO");
	}
	void AbrirPuerta()
	{
		//animacion puerta y activar el collider para cambiar el mapa 
		puerta_cerrada.SetActive(false);
		abierto = true;

	}
	
	// Update is called once per frame
	void Update () {
		if(objetosConseguidos>=objetosNecesarios){
			AbrirPuerta();

		}
	}
		void OnTriggerEnter2D (Collider2D objeto)
		{
		if (objeto.transform.tag == "Player" && abierto)
		{
			Application.LoadLevel("Hall");
		}
		}
	}
