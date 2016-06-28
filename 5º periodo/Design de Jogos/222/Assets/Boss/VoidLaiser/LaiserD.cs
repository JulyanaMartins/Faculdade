using UnityEngine;
using System.Collections;

public class LaiserD : MonoBehaviour {

	public GameObject May;

	 void Update() {

		May = GameObject.Find ("May(Clone)");

	}
	// Use this for initialization
	void OnParticleCollision(){

		if(May.GetComponent<Maycontrol>().change_cor != 1)
		May.GetComponent<Maycontrol> ().die ();


	}
}
