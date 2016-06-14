using UnityEngine;
using System.Collections;

public enum Colores 
{
	Gris,Rojo,Verde,Azul
}
[RequireComponent (typeof (Rigidbody2D))]	
public class CH_Movimiento : MonoBehaviour {
	[Range(1f,10f)]		public float velocidad 		= 	10f;
	[Range(0f, 5f)]		public float fuerzaSalto 	= 	5f;

	public Colores colorPersonaje;

	LayerMask capa;						
	AudioSource comp_audiosourse;
	Rigidbody2D comp_rg;
	Animator comp_anim;
	SpriteRenderer comp_render;

	private Color rojo = new Color (0.698f,0.212f,0.125f,0.392f);
	private Color verde =  new Color (0.671f , 1f, 0.259f, 0.392f);
	private Color azul= new Color (0.145f,0.482f,0.698f,0.392f);

	void Awake(){
		comp_rg = GetComponent<Rigidbody2D> ();
		comp_anim = GetComponent<Animator> ();
		comp_audiosourse = GetComponent<AudioSource> ();
		comp_render = GetComponent<SpriteRenderer> ();

		comp_rg.constraints = RigidbodyConstraints2D.FreezeRotation;
	}

	void Update(){
		Controles ();
	}

	void Controles()
	{
		if (Input.GetKey(KeyCode.W) ){
			//Debug.Log ("W");
		}
		if (Input.GetKey (KeyCode.A)) {
			//Debug.Log ("A");
			comp_rg.velocity = new Vector2 (-velocidad, comp_rg.velocity.y);
			comp_render.flipX = true;
		} else {
			if (Input.GetKeyUp (KeyCode.A)) {
				comp_rg.velocity = new Vector2 (-1.1f, comp_rg.velocity.y);
			}
		}
		if (Input.GetKey(KeyCode.S) ){
			//Debug.Log ("S");
		}
		if (Input.GetKey (KeyCode.D)) {
			//Debug.Log ("D");
			comp_rg.velocity = new Vector2 (velocidad, comp_rg.velocity.y);
			comp_render.flipX = false;
		} else {
			if (Input.GetKeyUp (KeyCode.D)) {
				comp_rg.velocity = new Vector2 (01.1f, comp_rg.velocity.y);
			}
		}
		if (Input.GetKeyDown(KeyCode.Space) ){ //arreglar salto
			//Debug.Log ("Space");
			RaycastHit2D hitdown = Physics2D.Raycast(transform.position, -transform.up,1,capa);
			if (hitdown != null) {
				comp_rg.velocity = new Vector2 (0, fuerzaSalto);
				Debug.Log ("suelo");
			} else {

			}
		}
	}
	public void CambioColor() //hace que pueda cambiar de color si toca un objeto determinado
	{
		if (colorPersonaje == Colores.Gris)
		{
			
		}
		if (colorPersonaje ==  Colores.Rojo)
		{
			
		}
		if (colorPersonaje == Colores.Verde)
		{
			
		}
		if (colorPersonaje == Colores.Azul)
		{
			
		}
	} 
}

