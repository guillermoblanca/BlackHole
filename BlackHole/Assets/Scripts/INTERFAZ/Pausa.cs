using UnityEngine;
using System.Collections;

public class Pausa : MonoBehaviour {
	public GameObject opciones;
	public GameObject menu;
	public Animator anim;
	public float retraso;
	// Use this for initialization
	void Start () {
		menu.SetActive (false);
	
	}

	IEnumerator mostrarMenu(){
		yield return new WaitForSeconds (retraso);
		menu.SetActive (true);
		yield return new WaitForSeconds (1);
		print ("ENTRO");
		Time.timeScale=0;


	}

	public void continuar(){
		Time.timeScale = 1;
		anim.SetTrigger("DesactivarAnimacion");
		menu.SetActive(false);
	}

	public void salir (){
		Time.timeScale = 1;
		Application.LoadLevel ("04_MenuPrincipal");
		}




	void iniciarAnimacion(){
		anim.SetTrigger ("ActivarAnimacion");
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			
			if(menu.activeSelf){
				anim.SetTrigger("DesactivarAnimacion");
				menu.SetActive(false);
				Time.timeScale = 1;

			}
			else{
				iniciarAnimacion();
				StartCoroutine ("mostrarMenu");
			}

		}

			/*if(anim.GetBool("pausa")==false){
				muestra_menu ();
			}else{
				oculta_menu();*/



	}


	}








