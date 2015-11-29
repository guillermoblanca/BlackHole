﻿using UnityEngine;
using System.Collections;

public class ObjetoPuntos : MonoBehaviour {
	public AudioSource sonido;
	public bool Clave_objeto;// determina si es un objeto clave o no
	public int puntos; // suma puntos 
	public GameControl gc;//carga el gc

	void Start(){
		gc= GameObject.FindGameObjectWithTag("GameControl").GetComponent<GameControl>(); //encuentra el gc con el tag Gamecontrol para ejecutar la funcion dentro del gameobject
		sonido = GetComponent<AudioSource> ();
	}
	void OnTriggerEnter2D (Collider2D objeto)
	{

		if (objeto.transform.tag == "Player" && !Clave_objeto) // si no es objeto clave es caramelo y hace esto
		{sonido.Play ();
			//Debug.Log(sonido);

			//Debug.Log("hago algo");
			gc.Da_Puntos(1); // carga el gc y suma tantos puntos
			Destroy(gameObject,0.2f);// destruye este gameobject

		}
		if (objeto.transform.tag == "Player" && Clave_objeto) // es objeto clave y hace eto
		{sonido.Play ();
			//Debug.Log(sonido);
			gc.Recoge_Clave(1); // carga la variable recoger clave que es 1 
			Destroy(gameObject,0.9f); // destruye este gameobject
		}
	}
}
