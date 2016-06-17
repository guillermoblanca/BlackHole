using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameControl : MonoBehaviour {
	[Header ("Gestor puntos caramelos")]
	public int puntosCaramelos=0;
	public Text textoPuntos;
	[Header ("Gestor puntos objeto clave")]
	public bool objetoClave=false;
	private GameObject objetoClave_item;
	private GameObject puerta;
	// Use this for initialization
	void Start () {
		objetoClave_item = GameObject.Find ("objetoClave");
		puerta = GameObject.Find ("Puerta");
	}
	
	// Update is called once per frame
	void Update () {
		
		if (objetoClave_item != null) {
			objetoClave = false;
		} else {
			objetoClave = true;	

		}
	}
}
	