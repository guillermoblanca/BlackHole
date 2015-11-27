using UnityEngine;
using System.Collections;

public class ObjetoPuntos : MonoBehaviour {

void OnCollisionEnter2D (Collision2D objeto)
	{
		if (objeto.transform.tag == "Player")
		{
			Destroy(gameObject);
		}
	}
}
