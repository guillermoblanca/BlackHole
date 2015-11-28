using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Puerta : MonoBehaviour {
	GameControl gc;
	public bool abierto;
	int objetosConseguidos;
	public int objetosNecesarios;
	// Use this for initialization
	void Start () {
		abierto = false;
	}

	public void conseguirObjeto(){
		objetosConseguidos++;
		print ("OBJETO  CONSEGUIDO");
	}
	void AbrirPuerta()
	{
		//animacion puerta y activar el collider para cambiar el mapa 
	}
	
	// Update is called once per frame
	void Update () {
		if(objetosConseguidos>=objetosNecesarios){
			AbrirPuerta();
		}
	}
}
