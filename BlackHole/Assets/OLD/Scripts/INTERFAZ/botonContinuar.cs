using UnityEngine;
using System.Collections;

public class botonContinuar : MonoBehaviour {

	Animator anim;
	// Use this for initialization
	void Start () {
		anim =  GetComponent<Animator>();
	}
	
	// Update is called once per frame
	public void cargaContinuar ()
	{
		
		anim.SetBool ("confirmar", true);
		Debug.Log ("Pulsado");
	}
	public void sacaContinuar ()
	{
		
		anim.SetBool ("confirmar", false);
		Debug.Log ("Pulsado");
	}
}