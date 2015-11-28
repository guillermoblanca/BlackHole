using UnityEngine;
using System.Collections;

public class Cambio_Color : MonoBehaviour 
{
	public Coloreado colorEspectral;
	CambiaColor_CH scriptpersonaje;
	SpriteRenderer spriterenderer;
	// Use this for initialization
	void Start () {
		scriptpersonaje = GameObject.Find ("Jugador").GetComponent<CambiaColor_CH>();
		spriterenderer = GetComponent<SpriteRenderer>();

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
		}

	}
	void ColoresEspectral()
	{
		if (colorEspectral == Coloreado.Gris)
		{
			spriterenderer.color = new Color (1f,1f,1f);
		}
		if (colorEspectral == Coloreado.Rojo)
		{
			spriterenderer.color = new Color (1f,0f,0f);
		}
		if (colorEspectral == Coloreado.Verde)
		{
			spriterenderer.color = new Color (0f,1f,0f);
		}
		if (colorEspectral == Coloreado.Azul)
		{
			spriterenderer.color = new Color (0f,0f,1f);
		}
	}
}
