using UnityEngine;
using System.Collections;

public class fueraPausa : MonoBehaviour {

	public Animator anim;
	
	// Use this for initialization
	void Start () {
		anim =  GetComponent<Animator>();
	}
	

	public void sacaPausa ()
	{
		
		anim.SetBool ("pausa", false);
		Debug.Log ("Pulsado");
	}
}
