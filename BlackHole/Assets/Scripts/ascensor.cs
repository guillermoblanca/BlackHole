using UnityEngine;
using System.Collections;

public class ascensor : MonoBehaviour {
	Animator anim;


	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.transform.tag == "Caja") {
			anim.SetBool ("entra_caja", true);
		}else{
			anim.SetBool ("entra_caja", false);
		}
	}
	




	}

