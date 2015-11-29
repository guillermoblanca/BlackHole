using UnityEngine;
using System.Collections;

public class botonEmpezar : MonoBehaviour {
	public GameObject titulo;
    Animator anim;
	
	
    // Use this for initialization
	void Start () {
        anim =  GetComponent<Animator>();

    }
	
	
    public void Empezar ()
    {

			anim.SetBool ("empezando", true);
			Debug.Log ("Empieza");
			titulo.SetActive (false);
    }


}
