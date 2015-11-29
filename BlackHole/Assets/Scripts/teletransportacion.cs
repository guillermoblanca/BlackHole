using UnityEngine;
using System.Collections;

public class teletransportacion : MonoBehaviour {

	private GameObject destino;  //GameObject 
	public bool activo = false;
	public string nombre;// para buscar el gameobject 
	 public bool dentro = false;
	bool pulsado_tecla = false;
	bool pulsado; 
	GameObject Player;
	void Awake (){
		destino= GameObject.Find(nombre);// buscan mis gameobject con un string  
		Player= GameObject.Find("Jugador");// buscar el gamobject jugador y dice que es igual que player 
	}

	void Update(){


		if (Input.GetKeyDown (KeyCode.W)) {// controla si le pulsas a la tecla 
			pulsado_tecla = true;

		} else {
			pulsado_tecla = false;
		}



	}

	void FixedUpdate(){  //controla la condicion  para poder teleportar 
		if (pulsado_tecla && dentro) {
			dentro = false;
			pulsado_tecla = false;
			Player.transform.position= destino.transform.position;
			//Debug.Log("tecla pulsada");
		}
	}
	void OnTriggerStay2D (Collider2D col){  //se activa cuando algo se colisiona 
		if (col.transform.tag == "Player"  ) {// controlas si el personaje esta adentro de la colision 
			dentro= true;
			//Debug.Log (destino.transform.name);

		}

	}
	
	void OnTriggerExit2D (Collider2D col){  //se activa cuando algo se colisiona 
		if (col.transform.tag == "Player"  ) {// controlas si estas fuera de la coslision 

			dentro= false;
			
		}
		
	}
	/*void OnDrawGizmos(){

		Gizmos.color = Color.red;
		Gizmos.DrawLine(transform.position,destino.transform.position);
		*/
		
	}
	

	



