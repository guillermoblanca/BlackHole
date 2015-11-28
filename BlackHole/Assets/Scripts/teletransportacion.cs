using UnityEngine;
using System.Collections;

public class teletransportacion : MonoBehaviour {

	private GameObject destino;  //GameObject 
	public bool activo = false;
	public string nombre;
	 public bool dentro = false;
	bool pulsado_tecla = false;
	bool pulsado; 
	GameObject Player;
	void Awake (){
		destino= GameObject.Find(nombre);// buscando de mis objetos hijos 
		Player= GameObject.Find("Jugador");
	}

	void Update(){

		if (Input.GetKeyDown (KeyCode.W)) {
			pulsado_tecla = true;

		} else {
			pulsado_tecla = false;
		}



	}

	void FixedUpdate(){
		if (pulsado_tecla && dentro) {
			dentro = false;
			pulsado_tecla = false;
			Player.transform.position= destino.transform.position;
			Debug.Log("tecla pulsada");
		}
	}
	void OnTriggerStay2D (Collider2D col){  //se activa cuando algo se colisiona 
		if (col.transform.tag == "Player"  ) {
			dentro= true;
			Debug.Log (destino.transform.name);

		}

	}
	
	void OnTriggerExit2D (Collider2D col){  //se activa cuando algo se colisiona 
		if (col.transform.tag == "Player"  ) {

			dentro= false;
			
		}
		
	}
	/*void OnDrawGizmos(){

		Gizmos.color = Color.red;
		Gizmos.DrawLine(transform.position,destino.transform.position);
		*/
		
	}
	

	



