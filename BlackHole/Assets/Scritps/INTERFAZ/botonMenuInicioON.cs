using UnityEngine;
using System.Collections;

public class botonMenuInicioON : MonoBehaviour {


	Animator anim;
	// Use this for initialization
	void Start () {
		anim =  GetComponent<Animator>();
	}
	
	// Update is called once per frame
	public void cargaMenu ()
	{
		
		anim.SetBool ("cargamenu", true);
		Debug.Log ("Pulsado");

	}
	
}
