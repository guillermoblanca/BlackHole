using UnityEngine;
using System.Collections;

public class ObjetoPuntos : MonoBehaviour {
	public bool Clave_objeto;// determina si es un objeto clave o no
	public int puntos; // suma puntos 
	public GameControl gc;//carga el gc

	void Start(){
		gc= GameObject.FindGameObjectWithTag("GameControl").GetComponent<GameControl>(); //encuentra el gc con el tag Gamecontrol para ejecutar la funcion dentro del gameobject
	}
	void OnTriggerEnter2D (Collider2D objeto)
	{

		if (objeto.transform.tag == "Player" && !Clave_objeto) // si no es objeto clave es caramelo y hace esto
		{

			//Debug.Log("hago algo");
			gc.Da_Puntos(1); // carga el gc y suma tantos puntos
			Destroy(gameObject);// destruye este gameobject
		}
		if (objeto.transform.tag == "Player" && Clave_objeto) // es objeto clave y hace eto
		{
			gc.Recoge_Clave(1); // carga la variable recoger clave que es 1 
			Destroy(gameObject); // destruye este gameobject
		}
	}
}
