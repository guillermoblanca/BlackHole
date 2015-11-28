using UnityEngine;
using System.Collections;

public class botonNuevaPartida : MonoBehaviour {

	Animator anim;
	// Use this for initialization
	void Start () {
		anim =  GetComponent<Animator>();
	}
	
	// Update is called once per frame
	public void nuevaPartida ()
	{
		
		Application.LoadLevel ("00_Hall");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
