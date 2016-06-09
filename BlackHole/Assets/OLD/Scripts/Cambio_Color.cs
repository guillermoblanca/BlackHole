using UnityEngine;
using System.Collections;

public class Cambio_Color : MonoBehaviour 
{
	private AudioSource sonido;

	public Coloreado colorEspectral;
	CambiaColor_CH scriptpersonaje;
	SpriteRenderer spriterenderer;
	private Color rojo = new Color (0.698f,0.212f,0.125f,0.392f);
	private Color verde =  new Color (0.671f , 1f, 0.259f, 0.392f);
	private Color azul= new Color (0.145f,0.482f,0.698f,0.392f);
	// Use this for initialization
	void Start () {
		scriptpersonaje = GameObject.Find ("Jugador").GetComponent<CambiaColor_CH>();
		spriterenderer = GetComponent<SpriteRenderer>();
		sonido = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		ColoresEspectral();
	}
	void OnTriggerEnter2D (Collider2D objeto)
	{
		if (objeto.transform.tag == "Player")
		{
			scriptpersonaje.ColorPersonaje = colorEspectral;
			sonido.Play ();

		}

	}
	void ColoresEspectral()
	{
		if (colorEspectral == Coloreado.Gris)
		{
			spriterenderer.color = new Color (1f,1f,1f,0.392f);
		}
		if (colorEspectral == Coloreado.Rojo)
		{
			spriterenderer.color = rojo;
		}
		if (colorEspectral == Coloreado.Verde)
		{
			spriterenderer.color = verde;
		}
		if (colorEspectral == Coloreado.Azul)
		{
			spriterenderer.color = azul;
		}
	}
}
