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

	[HideInInspector] 
	public bool interactivo =false;
	private Rigidbody2D comp_rg;
	private Animator comp_anim;
	private SpriteRenderer comp_render;

	private Color rojo = new Color (0.698f,0.212f,0.125f,0.392f);
	private Color verde =  new Color (0.671f , 1f, 0.259f, 0.392f);
	private Color azul= new Color (0.145f,0.482f,0.698f,0.392f);

	void Awake(){
		
		comp_rg = GetComponent<Rigidbody2D> ();
		comp_anim = GetComponent<Animator> ();
		comp_render = GetComponent<SpriteRenderer> ();
		comp_rg.constraints = RigidbodyConstraints2D.FreezeRotation;
	}

	void Update(){
		Controles ();
		CambioColor ();
		ControlesGenerales ();
		//Debug.DrawRay (transform.position, -transform.up, Color.red);
	}

	void Controles()
	{
		
		//comp_rg.velocity = new Vector2 (-1.1f, comp_rg.velocity.y); //getkeyup A
		//comp_rg.velocity = new Vector2 (01.1f, comp_rg.velocity.y); //getkeyup D
	

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
	void ControlesGenerales(){
		float valorH = Input.GetAxis ("Horizontal"); //movimiento horizontal con mando y teclado 
		float valorV = Input.GetAxis ("Vertical");// movimiento vertical con mando y teclado, por si al final hacemos que suba escaleras o algo parecido
		bool botonInteractivo = Input.GetButton("Interactivo");
		interactivo = botonInteractivo; // boton para controlar fuera del script si esta en modo interactivo, REVISAR EN EL FUTURO


		if (valorH < 0) {
			comp_rg.velocity = new Vector2 (-velocidad, comp_rg.velocity.y);
			comp_render.flipX = true;
		}else {
			if (valorH > 0) {
				comp_rg.velocity = new Vector2 (velocidad, comp_rg.velocity.y);
				comp_render.flipX = false;
			}
		if (Input.GetButton ("Salto")) {
				RaycastHit2D hitdown = Physics2D.Raycast(transform.position, -transform.up, 1, capa);
				if (hitdown.collider != null) 
				{
					comp_rg.velocity = new Vector2(0,fuerzaSalto); // salta  en y 
				}
			}
		}
	}
}

