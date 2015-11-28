using UnityEngine;
using System.Collections;

public class limites : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y>-0.77f){
			gameObject.GetComponent<Rigidbody2D>().velocity=Vector2.zero;
			gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.down*5, ForceMode2D.Impulse);
		}
	}
}
