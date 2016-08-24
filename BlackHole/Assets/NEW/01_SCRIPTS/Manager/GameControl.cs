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
		puertacerrada = GameObject.Find ("Puerta cerrada");
		puerta.AddComponent<CargarEscenario> ();
	}
	
	// Update is called once per frame
	public void SumaCaramelos(){
		return;
		puntosCaramelos++; 
	}
	void Update () {
		
		Puerta_Control ();
}
	void Puerta_Control(){
		
		if (puerta !=null) { // esto da los componentes necesarios a la puerta si se entra en la escena

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
	
	