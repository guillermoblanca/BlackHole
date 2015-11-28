using UnityEngine;
using System.Collections;

public class ObjetoPuntos : MonoBehaviour {
	public int puntos;
	bool dapuntos;
	GameControl gc;
	void Awake()
	{
		gc = GetComponent<GameControl>();
	}
	void Update()
	{
	
	}
void OnTriggerEnter2D (Collider2D objeto)
	{
		if (objeto.transform.tag == "Player" )
		{
			gc.Da_Puntos(5);
			Destroy(this);

		}
	}
}
