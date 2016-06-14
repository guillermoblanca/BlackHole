using UnityEngine;
using System.Collections;
[RequireComponent (typeof (BoxCollider2D))]
public class ZonaCambioColor : MonoBehaviour {
	public Colores colorObjeto;

	private SpriteRenderer comp_render;
	CH_Movimiento personaje;

	private Color rojo = new Color (0.698f,0.212f,0.125f);
	private Color verde =  new Color (0.671f , 1f, 0.259f);
	private Color azul= new Color (0.145f,0.482f,0.698f);

	BoxCollider2D col;

	void Start(){
		col = GetComponent<BoxCollider2D> ();
		col.isTrigger = true;
		personaje = GameObject.Find("Player").GetComponent<CH_Movimiento> ();
		comp_render = GetComponent<SpriteRenderer> ();
	}
	void Update(){
		Color ();
	}
	void Color(){
		if (colorObjeto == Colores.Gris) {
			comp_render.color = new Color (1f, 1f, 1f);
		}
		if (colorObjeto == Colores.Rojo) {
			comp_render.color = rojo;
		}
		if (colorObjeto == Colores.Verde) {
			comp_render.color = verde;
		}
		if (colorObjeto == Colores.Azul) {
			comp_render.color = azul;
		}
	}
	void OnTriggerEnter2D(Collider2D obj){
		if (obj.transform.CompareTag("Player")){
			personaje.colorPersonaje = colorObjeto;
		}
	}
}
