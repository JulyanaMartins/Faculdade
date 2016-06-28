using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class Staart2 : MonoBehaviour {
	public GameObject MinionVoid;
	public GameObject May;
	public GameObject Arma;
	public GameObject canvas;
	public GameObject Bar;
	GameObject aura;

	public GameObject insMay;
	public GameObject inscanvas;
	public GameObject insBar;




	// Use this for initialization
	void Start () {


		inscanvas =	Instantiate (canvas);

		insBar =	Instantiate (Bar);




		//Instantiate (VoidMinion, pos, VoidMinion.transform.rotation);
		//Instantiate (VoidMinion, pos2, VoidMinion.transform.rotation);
		StartCoroutine (mayins ());
	}

	IEnumerator mayins(){
		yield return new WaitForSeconds (0f);
		insMay =	Instantiate (May, new Vector3(0, 0, -42), May.transform.rotation) as GameObject;
		insMay.GetComponent<Maycontrol> ().vida = 5;
		insMay.GetComponent<Maycontrol> ().LifeBar = insBar;

		aura = GameObject.Find ("AuraMay");

		inscanvas.GetComponentInChildren<inffm> ().Aura = aura;
		inscanvas.GetComponentInChildren<inffm> ().a = true;

		inscanvas.GetComponentInChildren<infCc> ().Aura = aura;
		inscanvas.GetComponentInChildren<infCc> ().a = true;

		inscanvas.GetComponentInChildren<infG> ().Aura = aura;
		inscanvas.GetComponentInChildren<infG> ().a = true;





	}


	void Update(){
	
	

		if (Input.GetKey (KeyCode.R))
			SceneManager.LoadScene("cena_03");

		
	}

}