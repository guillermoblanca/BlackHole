using UnityEngine;
using System.Collections;

public class TUTORIAL : MonoBehaviour {

	private AudioSource sonido;
	public GameObject sig1, sig2, sig3, sig4, sig5, emp;

	void Awake()
	{
		sonido = GetComponent<AudioSource> ();
	}

	public void Siguiente1 (){
	
		sonido.Play ();
		sig1.SetActive (false);
		sig2.SetActive (true);
	}

	public void Siguiente2 (){

		sonido.Play ();
		sig2.SetActive (false);
		sig3.SetActive (true);
	
	}

	public void Siguiente3 (){
	
		sonido.Play ();
		sig3.SetActive (false);
		sig4.SetActive (true);
	}

	public void Siguiente4 (){

		sonido.Play ();
		sig4.SetActive (false);
		sig5.SetActive (true);
	}

	public void Siguiente5 (){
		
		sonido.Play ();
		sig5.SetActive (false);
		emp.SetActive (true);
	}

	public void empezar (){

		sonido.Play ();
		emp.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
