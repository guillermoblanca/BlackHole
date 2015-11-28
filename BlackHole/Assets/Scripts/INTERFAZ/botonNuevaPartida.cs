using UnityEngine;
using System.Collections;

public class botonNuevaPartida : MonoBehaviour {


	// Use this for initialization
	void Start () {

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
