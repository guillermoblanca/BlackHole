using UnityEngine;
using System.Collections;

public class botonMenuInicioON : MonoBehaviour {

	private AudioSource sonido;
	Animator anim;
	// Use this for initialization
	void Start () {
		anim =  GetComponent<Animator>();
	}
	
	// Update is called once per frame
	public void cargaMenu ()
	{
		sonido = GetComponent<AudioSource> ();
		anim.SetBool ("cargamenu", true);
		Debug.Log ("Pulsado");

	}

	public void sacaMenu ()
	{
		
		anim.SetBool ("cargamenu", false);
		Debug.Log ("Pulsado");
}
}