using UnityEngine;
using System.Collections;

public class MovimientoPersonaje : MonoBehaviour {

	[Range (0,10)] public float velocidad = 10f;
	public float fuerzaSalto;
	public bool enSalto;
	public bool miraIzq;

	CircleCollider2D detectorSuelo;

	Rigidbody2D rg;
	void Awake()
	{
		detectorSuelo = GameObject.Find ("ComprobadorSuelo").GetComponent<CircleCollider2D>();
		rg= GetComponent<Rigidbody2D>();
	}
	void Update() // Controles
	{
		if (Input.GetKey(KeyCode.A)) // izq
		{
			MoverIzq(velocidad);
		}
		if (Input.GetKeyUp(KeyCode.A)) //izq
		{
			MoverIzq(0);
		}
		if (Input.GetKey(KeyCode.D))// drcha
		{
			MoverDrch(velocidad);
		}
		if (Input.GetKeyUp(KeyCode.D))// drcha
		{
			MoverDrch(0);
		}
		if (Input.GetKey(KeyCode.Space))
		{
			rg.AddForce (new Vector2(0,fuerzaSalto));
		}
	}
	void OnCollisionEnter2D (Collision2D objeto)
	{
		if (detectorSuelo)
		{
			Debug.Log ("toco algo");
		}
	}
	void MoverIzq(float velocidad)
	{
		rg.velocity = new Vector2 (-velocidad, 0);
	}
	void MoverDrch(float velocidad)
	{
		rg.velocity = new Vector2(velocidad,0);
	}

}
