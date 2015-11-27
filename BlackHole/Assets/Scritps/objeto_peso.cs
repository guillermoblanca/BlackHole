using UnityEngine;
using System.Collections;

public class objeto_peso : MonoBehaviour {
	public Coloreado objetoColor;
	CambiaColor_CH scriptpersonaje;
	Rigidbody2D rg;


	void Start () {
		rg=GetComponent<Rigidbody2D>(); //se coge el rigid body y se inicia con el juego
		scriptpersonaje = GetComponent<CambiaColor_CH> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D objeto){ // se le dice al collider que si lo que entra en contacto con el es el jugador. 
		if (objeto.transform.tag == "player") { //este desactivara su kinematic
			rg.isKinematic = false;
		}
	}
		void OnCollisionEnter2D (Collision2D objeto)
		{
		if (objeto.transform.tag == "player") {
			objetoColor == scriptpersonaje.ColorPersonaje;

		}
		}
	}

