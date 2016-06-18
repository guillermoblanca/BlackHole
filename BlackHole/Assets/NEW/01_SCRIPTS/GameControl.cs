using UnityEngine;
using System.Collections;
using UnityEngine.UI;
[RequireComponent(typeof (CanvasScript))]
public class GameControl : MonoBehaviour {
	[Header ("Gestor puntos caramelos")]
	public int puntosCaramelos=0;
	public Text textoPuntos;
	[Header ("Gestor puntos objeto clave")]
	public bool objetoClave=false;
	private GameObject objetoClave_item;
	private GameObject puerta, puertacerrada;
	// Use this for initialization
	void Start () {
		objetoClave_item = GameObject.Find ("objetoClave");
		puerta = GameObject.Find ("Puerta");

		if (puerta != null) {
			puerta.AddComponent<CargarEscenario> ();
		}

		puertacerrada = GameObject.Find ("Puerta cerrada");
		DontDestroyOnLoad (transform.gameObject);
	}
	
	// Update is called once per frame
	public void SumaCaramelos(){
		return;
		puntosCaramelos++; 
	}
	void Update () {
		if (puerta !=null) {
		if (puerta.GetComponent<BoxCollider2D> () == null) {
			puerta.AddComponent<BoxCollider2D> ();
		}
		BoxCollider2D puertabox = puerta.GetComponent<BoxCollider2D> ();
		if (objetoClave_item != null) {
			objetoClave = false;
			puertabox.enabled = false;
		} else {
			objetoClave = true;	
			Destroy (puertacerrada);
			puertabox.enabled = true;
			puertabox.isTrigger = true;
		}
		}
	}

}
	