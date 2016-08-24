using UnityEngine;
using System.Collections;

public class cambioDeColor : MonoBehaviour {
	public Colores colorObjeto;

	private SpriteRenderer comp_render;
	CH_Movimiento personaje;

	private BoxCollider2D col;

	private static Color[] color_colores = {
		new Color(1f,1f,1f),
		new Color (0.698f,0.212f,0.125f), //rojo
		new Color (0.671f , 1f, 0.259f),// verde
		new Color (0.145f,0.482f,0.698f)// azul
	};
	void Start(){
		Initialize ();
	}
	void Update(){
		Color ();
	}
	void OnTriggerEnter2D(Collider2D obj)
	{
		if (obj.transform.CompareTag("Player")){
			personaje.colorPersonaje = colorObjeto;
		}
	}
	private void Initialize()
	{
		col = GetComponent<BoxCollider2D> ();
		col.isTrigger = true;
		personaje = GameObject.Find("Player").GetComponent<CH_Movimiento> ();
		comp_render = GetComponent<SpriteRenderer> ();
	}
	void Color()
	{
		if (colorObjeto == Colores.Gris) {
			comp_render.color = color_colores[0];
		}
		if (colorObjeto == Colores.Rojo) {
			comp_render.color = color_colores [1];
		}
		if (colorObjeto == Colores.Verde) {
			comp_render.color = color_colores[2];
		}
		if (colorObjeto == Colores.Azul) {
			comp_render.color = color_colores[3] ;
		}
	}

}
