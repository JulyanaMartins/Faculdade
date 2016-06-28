using UnityEngine;
using System.Collections;
public class Dimensionalcollider : MonoBehaviour {

	 bool active;
	int aux;
	public GameObject May;
	// Use this for initialization
	void Start () {
		active = false;
		aux = 0;
		StartCoroutine (ligar ());

		May = GameObject.Find ("May(Clone)");
	}

	void Update(){
	
		if (aux == 0) {
			if (active == true && May.GetComponent<Maycontrol> ().change_cor != 3) {
				May.GetComponent<Maycontrol> ().die ();
				aux = 1;
			}
		}
	
	}
	
	// Update is called once per frame

	IEnumerator ligar(){
	
		yield return new WaitForSeconds (0.2f);

		active = true;

		StartCoroutine (desligar ());
	}

	IEnumerator desligar(){

		yield return new WaitForSeconds (0.4f);
		active = false;

		Destroy(gameObject);
	
	}

}