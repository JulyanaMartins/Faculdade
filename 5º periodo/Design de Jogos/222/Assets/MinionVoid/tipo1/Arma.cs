using UnityEngine;
using System.Collections;

public class Arma : MonoBehaviour {

	public GameObject balaM;

	public GameObject balaC;

	public GameObject balaG;

	int tipoBala;


	public Transform Origem;

	public GameObject May;
	public bool alvo;

	float atackspeed;
	float changespeed;
	// Use this for initialization
	void Start () {
	atackspeed = 10f;
		changespeed = 4f;
		tipoBala = 1;

		//InvokeRepeating ("change",1f, 2.0f);

		InvokeRepeating ("gerar", 0.2f, atackspeed);
		InvokeRepeating ("change", 0.2f, changespeed);

		alvo = true;

	}

	// Update is called once per frame
	void Update () {
		
		if (alvo == true) {

		
			Vector3 Target = new Vector3 (May.GetComponent<Maycontrol> ().Maypos.position.x, transform.position.y, May.GetComponent<Maycontrol> ().Maypos.position.z);
		
			transform.LookAt (Target);
		
	


		}
	



	}

	void gerar(){



		if (tipoBala == 1) {
			GameObject ins = Instantiate (balaM, Origem.position, transform.rotation) as GameObject;
			ins.GetComponent<BasicAtack> ().dir = 0;
		
		}
		
		if (tipoBala == 2) {
			GameObject ins = Instantiate (balaC, Origem.position, transform.rotation) as GameObject;
			ins.GetComponent<BasicAtack> ().dir = 0;

		}

		if (tipoBala == 3) {
			GameObject ins = Instantiate (balaG, Origem.position, transform.rotation) as GameObject;
			ins.GetComponent<BasicAtack> ().dir = 0;

		}

		
	
	



}
	void change(){


		tipoBala = Random.Range (1, 4);


	}


}
