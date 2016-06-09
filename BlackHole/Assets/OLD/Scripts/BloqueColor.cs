using UnityEngine;
using System.Collections;

public class BloqueColor : MonoBehaviour 
{
	public Coloreado colorBloque;
	public bool horizontal; // si es horizontal es true si no es false
	private Color rojo = new Color (0.698f,0.212f,0.125f,0.72f);
	private Color verde =  new Color (0.671f , 1f, 0.259f, 0.72f);
	private Color azul= new Color (0.145f,0.482f,0.698f,0.72f);
	 bool botonpulsa; // para comprobar que esta pulsando el boton 

	CambiaColor_CH scriptpersonaje; 
	BoxCollider2D boxcollider2D;
	SpriteRenderer spriterenderer;


	void Awake()
	{
		scriptpersonaje =GameObject.FindWithTag ("Player").GetComponent <CambiaColor_CH>();
		boxcollider2D = GetComponent<BoxCollider2D>();
		spriterenderer = GetComponent<SpriteRenderer>();
		ColoresBloque();
	}
	void Update()
	{

		if (Input.GetKeyDown (KeyCode.S))
		{
			botonpulsa = true;
			Invoke ("pulsafalse",2f);
		}

	}
	void OnCollisionStay2D(Collision2D objeto) // cuando el personaje colisione si es del mismo color puede traspasarlo
	{
		if (objeto.transform.tag == "Player" && !horizontal && colorBloque == scriptpersonaje.ColorPersonaje )
		{

			boxcollider2D.isTrigger = true;
		}
		if (objeto.transform.tag == "Player" && colorBloque == scriptpersonaje.ColorPersonaje && horizontal == true && botonpulsa == true )
		{
			boxcollider2D.isTrigger = true;
		}
	}
	void ColoresBloque()
	{
		if (colorBloque == Coloreado.Gris)
		{
			spriterenderer.color = new Color (1f,1f,1f,0.72f);
		}
		if (colorBloque == Coloreado.Rojo)
		{
			spriterenderer.color = rojo;
		}
		if (colorBloque == Coloreado.Verde)
		{
			spriterenderer.color = verde;
		}
		if (colorBloque == Coloreado.Azul)
		{
			spriterenderer.color = azul;
		}
	}
	void pulsafalse (){
		botonpulsa = false;
		boxcollider2D.isTrigger = false;
	}

}
