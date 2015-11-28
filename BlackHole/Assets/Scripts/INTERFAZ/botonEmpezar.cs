using UnityEngine;
using System.Collections;

public class botonEmpezar : MonoBehaviour {

    Animator anim;
	
	
    // Use this for initialization
	void Start () {
        anim =  GetComponent<Animator>();

    }
	
	
    public void Empezar ()
    {

			anim.SetBool ("empezando", true);
			Debug.Log ("Empieza");

    }


}
