using UnityEngine;
using System.Collections;

public class EnemigoColor : MonoBehaviour {
	public GameObject particulasRojas, particulasVerdes, particulasAzules; // introduce el sistema de particulas
	public Coloreado colorEnemigo;
	public float tiempo=1;
	public Transform PuntoA;
	public Transform PuntoB;
	public AudioSource sonido;

	private Vector3 origen;
	private Vector3 destino;
	private float posicion = 0;
	private Color rojo = new Color (0.698f,0.212f,0.125f,0.72f);
	private Color verde =  new Color (0.671f , 1f, 0.259f, 0.72f);
	private Color azul= new Color (0.145f,0.482f,0.698f,0.72f);

	CambiaColor_CH scriptpersonaje;
	SpriteRenderer spriterenderer;
	// Use this for initialization
	void Awake () {
		scriptpersonaje =GameObject.FindWithTag ("Player").GetComponent <CambiaColor_CH>();
		spriterenderer = GetComponent <SpriteRenderer>();
		sonido = GetComponent<AudioSource> ();

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
			sonido.Play ();
			if (colorEnemigo == Coloreado.Gris){
				scriptpersonaje.ColorPersonaje = Coloreado.Gris;

			}
			if (colorEnemigo == Coloreado.Rojo){
				scriptpersonaje.ColorPersonaje = Coloreado.Rojo;
				GameObject particulas_Rojas = (GameObject)Instantiate (particulasRojas, transform.position, transform.rotation);
				Destroy(particulas_Rojas,1f);
			}
			if (colorEnemigo == Coloreado.Verde){
				scriptpersonaje.ColorPersonaje = Coloreado.Verde;
				GameObject particulas_Verdes = (GameObject)Instantiate (particulasVerdes, transform.position, transform.rotation);
				Destroy(particulas_Verdes,1f);
			}
			if (colorEnemigo == Coloreado.Azul){
				scriptpersonaje.ColorPersonaje = Coloreado.Azul;
				GameObject particulas_Azules = (GameObject)Instantiate (particulasAzules, transform.position, transform.rotation);
				Destroy(particulas_Azules,1f);
			}
		}
		
	}
	void Colores_Enemigo()
	{
		if (colorEnemigo == Coloreado.Gris)
		{
			spriterenderer.color = new Color (1f,1f,1f,0.72f);
		}
		if (colorEnemigo == Coloreado.Rojo)
		{
			spriterenderer.color = rojo;
		}
		if (colorEnemigo == Coloreado.Verde)
		{
			spriterenderer.color = verde;
		}
		if (colorEnemigo == Coloreado.Azul)
		{
			spriterenderer.color = azul;
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
			transform.localScale = new Vector2 (-1f,1f);
			//Debug.Log("En A");
		}
		
		if (transform.position.x == PuntoB.position.x && destino == PuntoB.position)
		{
			destino = PuntoA.position;
			origen = PuntoB.position;
			posicion = 0;
			transform.localScale = new Vector2 (1f,1f);
			//Debug.Log("En B");
		}
		transform.position = Vector3.Lerp (origen, destino, posicion); 

	}

}
