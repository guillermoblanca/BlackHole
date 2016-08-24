using UnityEngine;
using System.Collections;

public enum Colores 
{
	Gris,Rojo,Verde,Azul
}
[RequireComponent (typeof (Rigidbody2D))]	
public class CH_Movimiento : MonoBehaviour {
	[Range(1f,10f)]		public float velocidad 		= 	10f;
	[Range(0f, 10f)]		public float fuerzaSalto 	= 	5f;

	public Colores colorPersonaje;

	public 	LayerMask capa;						
	AudioSource comp_audiosourse;
	Rigidbody2D comp_rg;
	Animator comp_anim;
	[HideInInspector] 
	public bool interactivo =false;
	private SpriteRenderer comp_render;

	private Color rojo = new Color (0.698f,0.212f,0.125f,0.392f);
	private Color verde =  new Color (0.671f , 1f, 0.259f, 0.392f);
	private Color azul= new Color (0.145f,0.482f,0.698f,0.392f);

	void Awake(){
		name = "Player";
		transform.gameObject.tag = "Player";
		comp_rg = GetComponent<Rigidbody2D> ();
		comp_anim = GetComponent<Animator> ();
		comp_audiosourse = GetComponent<AudioSource> ();
		comp_render = GetComponent<SpriteRenderer> ();
		comp_rg.constraints = RigidbodyConstraints2D.FreezeRotation;
	}

	void Update(){
		Controles ();
		CambioColor ();
		//Debug.DrawRay (transform.position, -transform.up, Color.red);
	}

	void Controles()
	{
		if (Input.GetKey (KeyCode.W)) {
			//Debug.Log ("W");
			interactivo = true;

		} else {
			if (Input.GetKeyUp(KeyCode.W)){
				interactivo = false;
			}
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
		if (Input.GetKeyDown(KeyCode.Space))//salto espacio
		{
			RaycastHit2D hitdown = Physics2D.Raycast(transform.position, -transform.up, 1, capa);
			if (hitdown.collider != null) 
			{
				comp_rg.velocity = new Vector2(0,fuerzaSalto); // salta  en y 
			}
		}
	}
	public void CambioColor() //hace que pueda cambiar de color si toca un objeto determinado
	{
		/*Dependiendo de la habilidad seleccionada se activan
		 * una serie de poderes
		 */
		if (colorPersonaje == Colores.Gris)
		{
			comp_render.color = new Color (1, 1, 1, 0.5f);
			transform.localScale = new Vector3 (1f, 1f, 1f);
		
		}
		if (colorPersonaje ==  Colores.Rojo)
		{
			comp_render.color = rojo;
		}
		if (colorPersonaje == Colores.Verde)
		{
			comp_render.color = verde;
		}
		if (colorPersonaje == Colores.Azul)
		{
			comp_render.color = azul;
		//	transform.localScale = new Vector3 (0.5f, 0.5f);
		}
	} 
}

