using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class LightningPlasma : MonoBehaviour {
	public GameObject balaM;
	public GameObject balaC;
	public GameObject balaG;
	public GameObject balaV;

	public ParticleSystem Dm; 
	public ParticleSystem Dc;

	public ParticleSystem Dg;

	public GameObject spot;

	List<Vector3> pos= new List<Vector3>();
	List<GameObject> insSpot= new List<GameObject>();

	float atackspeed;
	float changespeed;
	int tipoBala;
	int consz;
	// Use this for initialization
	void Start () {
		consz = 15;
	
		pos.Add( new Vector3(-85, 0, consz));
		pos.Add( new Vector3(-69, 0, consz));
		pos.Add( new Vector3(-53, 0, consz));
		pos.Add( new Vector3(-37, 0, consz));
		pos.Add( new Vector3( -21, 0, consz));
		pos.Add( new Vector3(-5, 0, consz));
		pos.Add( new Vector3(11, 0, consz));
		pos.Add( new Vector3(27, 0, consz));
		pos.Add( new Vector3(43, 0, consz));
		pos.Add( new Vector3(59, 0, consz));



	




		atackspeed = 0.5f;
		changespeed = 0.1f;
		tipoBala = 1;

		InvokeRepeating ("gerar", 0.2f, atackspeed);

		InvokeRepeating ("change", 0.2f, changespeed);

		StartCoroutine (setspeed (0.4f, 4f, 0.2f, 0.1f, true));
		StartCoroutine (setspeed (0.3f, 6.5f, 0.2f, 0.1f, true));
		StartCoroutine (setspeed (0.1f, 10.5f,0.2f, 0.0f,  false));
		StartCoroutine (stop (12f));
		StartCoroutine (insSkill(13.3f, Dg));
		StartCoroutine (insWave(14.5f, spot, 10));

		StartCoroutine (stop (20f));


	}

	void gerar(){



		for (int i = -80; i < 85; i += 5) {
			
			if (tipoBala == 1) {
				GameObject ins = Instantiate (balaM, new Vector3 (i, 0, 42), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = 0;
			
			}
			if (tipoBala == 2) {
				GameObject ins = Instantiate (balaC, new Vector3 (i, 0, 42), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = 0;

			}
			if (tipoBala == 3) {
				GameObject ins = Instantiate (balaG, new Vector3 (i, 0, 42), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = 0;

			}
			if (tipoBala == 4) {
				GameObject ins = Instantiate (balaV, new Vector3 (i, 0, 42), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = 0;

			}
		
		}
	}



	IEnumerator stop(float after){
		yield return new WaitForSeconds (after);

		CancelInvoke ();
	}

	IEnumerator setspeed(float speed, float after, float afterC, float speedC, bool chang){
		yield return new WaitForSeconds (after);
		CancelInvoke ();
		InvokeRepeating ("gerar", 0.2f, speed);
		if(chang == true)
			InvokeRepeating ("change", afterC, speedC);
			
	}


	IEnumerator insSkill(float after, ParticleSystem d){
		yield return new WaitForSeconds (after);
		Instantiate (d);
	}




	//wave
	IEnumerator insWave(float after, GameObject w, int n){
		yield return new WaitForSeconds (after);

		//InvokeRepeating ("change", 0.2f, 0.1f);

		int k = 0;
		for (int i = 3; i < 8; i++) {
			

			insSpot.Add (Instantiate (w, pos [i], w.transform.rotation) as GameObject);
	
				insSpot [k].GetComponent<Spot> ().tipoBala = 4;
			k++;
		}



		StartCoroutine(ChangeL(insSpot, 3,0.5f));

		StartCoroutine(Clear(insSpot, 1f));

	}

	IEnumerator ChangeL(List<GameObject> insSpot, int cor,float delay){
		yield return new WaitForSeconds(delay);
		for (int i = 0; i < 10; i++)
			insSpot [i].GetComponent<Spot> ().tipoBala = 4;
	}


	IEnumerator Clear(List<GameObject> insSpot, float delay){
		yield return new WaitForSeconds(delay);
		for (int i = 0; i < 10; i++) 
		Destroy (insSpot [i]);
	
	}
	//wave






	void change(){


		tipoBala = Random.Range (1, 3);


		

	}

}
