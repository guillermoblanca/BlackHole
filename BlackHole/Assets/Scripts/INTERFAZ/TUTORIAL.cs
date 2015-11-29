using UnityEngine;
using System.Collections;

public class TUTORIAL : MonoBehaviour {

	public GameObject sig1, sig2,sig3,sig4,emp;

	


	public void Siguiente1 (){
	
		sig1.SetActive (false);
		sig2.SetActive (true);
	}

	public void Siguiente2 (){

		sig2.SetActive (false);
		sig3.SetActive (true);
	
	}

	public void Siguiente3 (){
	
		sig3.SetActive (false);
		sig4.SetActive (true);
	}

	public void Siguiente4 (){
		sig4.SetActive (false);
		emp.SetActive (true);
	}

	public void empezar (){

		emp.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
