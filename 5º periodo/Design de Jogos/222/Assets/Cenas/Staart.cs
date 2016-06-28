using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Staart : MonoBehaviour {
	public GameObject MinionVoid;
	public GameObject May;
	public GameObject Arma;
	public GameObject canvas;
	GameObject aura;

	public GameObject insMay;
	public GameObject inscanvas;

	 List<GameObject> InsMinions= new List<GameObject>();

	 List<Vector3> pos= new List<Vector3>();


	// Use this for initialization
	void Start () {
		

		inscanvas =	Instantiate (canvas);


		pos.Add( new Vector3(0, 0, 45));
		pos.Add( new Vector3(-80, 0, 45));
		pos.Add (new Vector3(80, 0, 45));


			for (int x = 0; x < 3; x++)
				InsMinions.Add (Instantiate (MinionVoid, pos [x], MinionVoid.transform.rotation) as GameObject);
		


		
		//Instantiate (VoidMinion, pos, VoidMinion.transform.rotation);
		//Instantiate (VoidMinion, pos2, VoidMinion.transform.rotation);
		StartCoroutine (mayins ());
	}

	IEnumerator mayins(){
		yield return new WaitForSeconds (3f);
		//May.GetComponent<Maycontrol> ().fine = true;
		insMay =	Instantiate (May) as GameObject;

	

		//insMinion.GetComponentInChildren<Arma>().May = insMay;
		InsMinions [0].GetComponentInChildren<Arma> ().May = insMay;
		InsMinions [1].GetComponentInChildren<Arma> ().May = insMay;
		InsMinions [2].GetComponentInChildren<Arma> ().May = insMay;

		aura = GameObject.Find ("AuraMay");


		inscanvas.GetComponentInChildren<inffm> ().Aura = aura;
		inscanvas.GetComponentInChildren<inffm> ().a = true;

		inscanvas.GetComponentInChildren<infCc> ().Aura = aura;
		inscanvas.GetComponentInChildren<infCc> ().a = true;

		inscanvas.GetComponentInChildren<infG> ().Aura = aura;
		inscanvas.GetComponentInChildren<infG> ().a = true;



	


		//Aura.GetComponent<AuraMay> ().May = insMay;
		//Arma.GetComponent<Arma> ().May = insMay;
		//Minion.GetComponent<MinionVoid> ().setMay (insMay);
		//insMinion.GetComponent<tipo1>().x = 4;

	}

}
