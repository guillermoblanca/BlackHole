using UnityEngine;
using System.Collections;

public class MovimientoPersonaje : MonoBehaviour {


	[Range (0,10)] public float velocidad = 10f;
	public float fuerzaSalto;
	public bool enSalto;
	public bool miraIzq;
	public bool enSuelo;
	Transform detectorSuelo;
	// falta que salte solo una vez 
	Rigidbody2D rg;
	Animator anim;




	void Awake()
	{
		anim = GetComponent <Animator> ();
		rg= GetComponent<Rigidbody2D>();
	}
	void Update() // Controles
	{
		Controles();
	}
	void MoverIzq(float velocidad)
	{
		rg.velocity  = new Vector2 (-velocidad, rg.velocity.y);
		miraIzq = true;
		anim.SetBool ("andando", true);
	}
	void MoverDrch(float velocidad)
	{
		rg.velocity  = new Vector2(velocidad,rg.velocity.y);
		miraIzq = false;

	}
	 void Salto()
	{
		rg.velocity = new Vector2(0,fuerzaSalto);
	}
	void Flip()
	{
		if (miraIzq)
		{
			transform.localScale = new Vector2 (-1f,1f);
		}
		if (!miraIzq)
		{
			transform.localScale = new Vector2 (1f,1f);
		}
	}
	void Controles()
	{
		if (Input.GetKey(KeyCode.A)) // izq
		{
			MoverIzq(velocidad);
			Flip();
			anim.SetBool ("andando", true);
		}

		if (Input.GetKeyUp(KeyCode.A)) //izq
		{
			MoverIzq(0);
			anim.SetBool ("andando", false);
		}
		if (Input.GetKey(KeyCode.D))// drcha
		{
			MoverDrch(velocidad);
			Flip();
			anim.SetBool ("andando", true);
		}
		if (Input.GetKeyUp(KeyCode.D))// drcha
		{
			MoverDrch(0);
			anim.SetBool ("andando", false);
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Salto ();
		}
	}
}

