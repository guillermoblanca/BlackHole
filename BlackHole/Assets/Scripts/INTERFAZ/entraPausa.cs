﻿using UnityEngine;
using System.Collections;

public class entraPausa : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Start () {
		anim =  GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.Escape)) {
			anim.SetBool ("pausa", true);
		}

	}
}
