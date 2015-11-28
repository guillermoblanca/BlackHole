using UnityEngine;
using System.Collections;

public class ObjetoPuntos : MonoBehaviour {
	public int puntos;
	bool dapuntos;
	GameControl gc;
	void Awake()
	{

		gc = GameObject.Find ("Game_Control").GetComponent<GameControl>();
	}
	void Update()
	{
	
	}
void OnTriggerEnter2D (Collider2D objeto)
	{
		if (objeto.transform.tag == "Player" )
		{
			Debug.Log("hago algo");
			gc.Da_Puntos(5);
			Destroy(gameObject);

		}
	}
}
