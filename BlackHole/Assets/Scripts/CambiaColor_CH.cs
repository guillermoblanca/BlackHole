using UnityEngine;
using System.Collections;
public enum Coloreado 
{
	Gris,Rojo,Verde,Azul
}
public class CambiaColor_CH : MonoBehaviour {
	public Coloreado ColorPersonaje; // caracteristica que variara algunas habilidades del personaje
	private Color rojo = new Color (0.698f,0.212f,0.125f,0.392f);
	private Color verde =  new Color (0.671f , 1f, 0.259f, 0.392f);
	private Color azul= new Color (0.145f,0.482f,0.698f,0.392f);
		// no se puede optimizar con el spriterenderer, debe resolverse prioridad 1

	// hemos querido dividir en voids los colores para meterle habilidades si hay tiempo 
	void Awake ()
	{
		ColorPersonaje = Coloreado.Gris; // inicia siempre en gris
	}
	void Update() //carga la caracteristica CambioColor que ira variando dependiendo de lo que interactue con el 
	{
		CambioColor();
		Debug.Log (rojo);
		Debug.Log (verde);
		Debug.Log (azul);
	}

	public void CambioColor() //hace que pueda cambiar de color si toca un objeto determinado
	{
		if (ColorPersonaje == Coloreado.Gris)
		{
			Gris();
		}
		if (ColorPersonaje ==  Coloreado.Rojo)
		{
			Rojo();
		}
		if (ColorPersonaje == Coloreado.Verde)
		{
			Verde();
		}
		if (ColorPersonaje == Coloreado.Azul)
		{
			Azul();
		}
	} 
	void Gris(){
		GetComponent<SpriteRenderer>().color  = new Color (1f,1f,1f,0.5f); // el color es el mismo de el inicio
	}	
	void Rojo()
	{
		GetComponent<SpriteRenderer>().color = rojo; // color rojo
	}
	void Verde()
	{
		GetComponent<SpriteRenderer>().color = verde; // color verde
	}
	void Azul()
	{	
		GetComponent<SpriteRenderer>().color = azul; // color azul 	
	}
}
