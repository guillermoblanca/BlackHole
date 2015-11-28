using UnityEngine;
using System.Collections;

public class ObjetoPuntos : MonoBehaviour {
	public bool Clave_objeto;
	public int puntos;
	bool dapuntos;
	public GameControl gc;

	void Awake()
	{

	}

	void Start(){
		gc= GameObject.FindGameObjectWithTag("GameControl").GetComponent<GameControl>();
	}
	void Update()
	{
	
	}

	void OnTriggerEnter2D (Collider2D objeto)
	{

		if (objeto.transform.tag == "Player" && !Clave_objeto)
		{

			//Debug.Log("hago algo");
			gc.Da_Puntos(5);
			Destroy(gameObject);
		}
		if (objeto.transform.tag == "Player" && Clave_objeto)
		{
			gc.Recoge_Clave(1);
			Destroy(gameObject);
		}
	}
}
