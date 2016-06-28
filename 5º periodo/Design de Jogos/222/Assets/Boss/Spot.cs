using UnityEngine;
using System.Collections;

public class Spot : MonoBehaviour {

	public GameObject balaM;

	public GameObject balaC;

	public GameObject balaG;

	public GameObject balaV;

	public int tipoBala;


	public Transform Origem;

	public GameObject May;
	public bool alvo;

	float atackspeed;
	// Use this for initialization
	void Start () {

		atackspeed = 0.1f;

		//InvokeRepeating ("change",1f, 2.0f);

		InvokeRepeating ("gerar", 0.2f, atackspeed);

		alvo = true;

	}

	// Update is called once per frame
	void Update () {
		May = GameObject.Find ("May(Clone)");
		if (alvo == true) {


			Vector3 Target = new Vector3 (May.GetComponent<Maycontrol> ().Maypos.position.x, transform.position.y, May.GetComponent<Maycontrol> ().Maypos.position.z);

			transform.LookAt (Target);




		}




	}

	void gerar(){



		if (tipoBala == 1) 
			Instantiate (balaM, Origem.position, transform.rotation);


		if (tipoBala == 2) 
			Instantiate (balaC, Origem.position, transform.rotation);



		if (tipoBala == 3) 
			Instantiate (balaG, Origem.position, transform.rotation);

		if (tipoBala == 4) 
			Instantiate (balaV, Origem.position, transform.rotation);







	}


}

