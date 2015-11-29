using UnityEngine;
using System.Collections;

public class botonEmpezar : MonoBehaviour {
	public GameObject titulo;
    Animator anim;
	private AudioSource sonido;
	
    // Use this for initialization
	void Start () {
        anim =  GetComponent<Animator>();
		sonido = GetComponent<AudioSource> ();
    }
	
	
    public void Empezar ()
    {

			anim.SetBool ("empezando", true);
			Debug.Log ("Empieza");
			titulo.SetActive (false);
			sonido.Play();
	}


}
