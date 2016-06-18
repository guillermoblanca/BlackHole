using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class CargarEscenario : MonoBehaviour {
	public bool puerta = false;
	CH_Movimiento ch;
	// Use this for initialization
	void Start () {
		ch = GameObject.Find ("Player").GetComponent<CH_Movimiento> ();
		if (name == "Puerta") {
			puerta = true;
		} else {
			puerta = false;
		}
	}
	
	// Update is called once per frame
	void OnTriggerStay2D(Collider2D obj){
		if (obj.name == "Player" && puerta ) {
			if (ch.interactivo) {
				Debug.Log ("Puerta abierta");
				// falta anadir el lvl correspondiente al hall
				SceneManager.LoadScene("01 pruebas de nivel");

			}
		}
	}
}
