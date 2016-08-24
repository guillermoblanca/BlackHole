using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CanvasScript : MonoBehaviour {
	private GameObject CanvasObj;
	GameControl gc;
	// Use this for initialization
	void Awake () {
		
		gc = GetComponent<GameControl> ();
		if (GameObject.Find("Canvas") == null){
		CanvasObj = new GameObject();
		CanvasObj.name = "Canvas";
		CanvasObj.AddComponent<Canvas> ();
		Canvas micanvas = CanvasObj.GetComponent<Canvas> ();
		micanvas.renderMode = RenderMode.ScreenSpaceOverlay;
		CanvasObj.AddComponent<Text> ();
		Text mitexto = CanvasObj.GetComponent<Text> ();
		Font mifuente = Resources.Load<Font> ("font");
		mitexto.font = mifuente;
		mitexto.text = ("caramelos: " +gc.puntosCaramelos + " objeto clave conseguido : " +gc.objetoClave) ;

		//Canvas miCanvas = CanvasObj.GetComponent<Canvas> ();
		}
	}
}