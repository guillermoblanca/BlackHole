using UnityEngine;
using System.Collections;

public class MovimientoPersonaje : MonoBehaviour {


	[Range (0,10)] public float velocidad = 10f; //determina la velocidad a la que se mueve, hemos determinado que el rango esta entre 0 y 10 siendo el 6 el que mejor nos parece
	private AudioSource sonido; // para cargar sonido de salto
	public float fuerzaSalto; // para determinar la fuerza con la que salta 
	public LayerMask capa; // para determinar la capa por la que puede saltar, es suelo
	bool miraIzq;// parar determinar hacia que lado mira y que mire hacia esto
	Rigidbody2D rg;// para utilizar las variables de rigidbody2d
	Animator anim; // para cargar animaciones
	void Awake() //carga al inicio de todo
	{
		// variables que se iran cargando, se ejecutan al inicio para ahorrar recursos a posteriori
		anim = GetComponent <Animator> ();
		rg= GetComponent<Rigidbody2D>();
		sonido = GetComponent<AudioSource> ();
	}
	void Update() // Controles
	{
		Controles(); // ejecuta constantemente las variables de controles, 
	}
	void MoverIzq(float velocidad) // mueve a la izquierda con una velocidad constante el float velocidad hace que pueda variar en controles
	{
		rg.velocity  = new Vector2 (-velocidad, rg.velocity.y);
		miraIzq = true;
		anim.SetBool ("andando", true);
	}
	void MoverDrch(float velocidad)// mueve a la derecha con una velocidad constante el float velocidad hace que pueda variar en controles
	{
		rg.velocity  = new Vector2(velocidad,rg.velocity.y);
		miraIzq = false;
	}
	 void Salto()// funcion para saltar
	{

		RaycastHit2D hitdown = Physics2D.Raycast(transform.position, -transform.up, 1, capa);// lanza un rayo hacia el suelo para saber en que capa esta y si puede sdaltar
		if (hitdown.collider != null) // si es diferente de nulo y cumple las variables de el rayo puede hacer eso
		{
		rg.velocity = new Vector2(0,fuerzaSalto); // salta  en y 
			sonido.Play (); // realiza sonido, solo cuando salta
		}

	}
	void Flip() // hace el giro mediante el escalado del personaje
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
	void Controles() // controles del juego, dos posiciones para camibar las variables
	{
		if (Input.GetKey(KeyCode.A)) // izq
		{
			MoverIzq(velocidad);
			Flip();
			anim.SetBool ("andando", true);
		}

		if (Input.GetKeyUp(KeyCode.A))  //izq
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
		if (Input.GetKeyDown(KeyCode.Space))//salto espacio
		{
			Salto ();
			anim.SetBool("Ensalto", true);
			Invoke("finSalto",1f);
		}
	}
	void finSalto()
	{
		anim.SetBool("Ensalto", false);
	}
}

