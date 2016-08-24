using UnityEngine;
using System.Collections;
[RequireComponent (typeof(BoxCollider2D))]
[RequireComponent (typeof(AudioSource))]
public class ObjetoClave : MonoBehaviour {
	private BoxCollider2D boxcol;
	private SpriteRenderer comp_render;
	private AudioSource comp_audio;
	public AudioClip objetoclavesonido;

	void Awake(){
		name = "objetoClave";
		boxcol = GetComponent<BoxCollider2D> ();
		comp_audio = GetComponent<AudioSource> ();
		comp_render = GetComponent<SpriteRenderer> ();
		boxcol.isTrigger = true;
		if (objetoclavesonido == null) {
			Debug.Log("Falta clip de sonido en : " +name);
		}
	}
	void OnTriggerEnter2D(Collider2D col){
		// debe sustituirse esto en el futuro con un sound manager 
		if (col.name == "Player") {
			comp_audio.PlayOneShot (objetoclavesonido,0.5f);
			comp_render.enabled = false;
			Destroy (gameObject,1f);
		}
	}
}
