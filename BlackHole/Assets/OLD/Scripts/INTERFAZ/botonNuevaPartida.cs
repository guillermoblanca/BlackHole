using UnityEngine;
using System.Collections;

public class botonNuevaPartida : MonoBehaviour {

	private AudioSource sonido;

	// Use this for initialization
	void Start () {
		sonido = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	public void nuevaPartida ()
	{
		sonido.Play ();
		Application.LoadLevel ("00_HallTuto");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
