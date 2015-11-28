using UnityEngine;
using System.Collections;

public class EnemigoColor : MonoBehaviour {

	public Coloreado colorEnemigo;
	public float tiempo=1;
	public Transform PuntoA;
	public Transform PuntoB;

	private Vector3 origen;
	private Vector3 destino;
	private float posicion = 0;

	CambiaColor_CH scriptpersonaje;
	SpriteRenderer spriterenderer;
	// Use this for initialization
	void Awake () {
		scriptpersonaje =GameObject.FindWithTag ("Player").GetComponent <CambiaColor_CH>();
		spriterenderer = GetComponent <SpriteRenderer>();
		destino = PuntoB.position;
		origen = PuntoA.position;
		posicion = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Movimiento();
		Colores_Enemigo();
	}
	void OnTriggerEnter2D(Collider2D objeto)
	{
		if (objeto.transform.tag == "Player"){
			if (colorEnemigo == Coloreado.Gris){
				scriptpersonaje.ColorPersonaje = Coloreado.Gris;
			}
			if (colorEnemigo == Coloreado.Rojo){
				scriptpersonaje.ColorPersonaje = Coloreado.Rojo;
			}
			if (colorEnemigo == Coloreado.Verde){
				scriptpersonaje.ColorPersonaje = Coloreado.Verde;
			}
			if (colorEnemigo == Coloreado.Azul){
				scriptpersonaje.ColorPersonaje = Coloreado.Azul;
			}
		}
		
	}
	void Colores_Enemigo()
	{
		if (colorEnemigo == Coloreado.Gris)
		{
			spriterenderer.color = new Color (1f,1f,1f);
		}
		if (colorEnemigo == Coloreado.Rojo)
		{
			spriterenderer.color = new Color (1f,0f,0f);
		}
		if (colorEnemigo == Coloreado.Verde)
		{
			spriterenderer.color = new Color (0f,1f,0f);
		}
		if (colorEnemigo == Coloreado.Azul)
		{
			spriterenderer.color = new Color (0f,0f,1f);
		}
	}
	void Movimiento()
	{
		
		posicion += Time.deltaTime * tiempo;
		if (transform.position.x == PuntoA.position.x && destino == PuntoA.position)
		{
			destino = PuntoB.position;
			origen = PuntoA.position;
			posicion = 0;
			transform.localScale =new Vector2 (1f,1f)*2;
			//Debug.Log("En A");
		}
		
		if (transform.position.x == PuntoB.position.x && destino == PuntoB.position)
		{
			destino = PuntoA.position;
			origen = PuntoB.position;
			posicion = 0;
			transform.localScale = new Vector2 (-1f,1f)*2;
			//Debug.Log("En B");
		}
		transform.position = Vector3.Lerp (origen, destino, posicion); 

	}

}
