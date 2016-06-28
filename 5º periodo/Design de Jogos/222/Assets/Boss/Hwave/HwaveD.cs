using UnityEngine;
using System.Collections;

public class HwaveD : MonoBehaviour {
	public GameObject balaM;
	public GameObject balaC;
	public GameObject balaG;
	public GameObject balaV;
	public int tipoBala;
	public bool on = false;
	public int tipoW;
	public float speed;
	public float after;
	public float tempo;
	public int sort = 0;
	int aux = 0;
	// Use this for initialization
	void Start () {

		aux = 0;

		StartCoroutine (end (tempo));

		if(tipoW == 1)
			InvokeRepeating ("RsetHF", after, speed);

		else if(tipoW == 2)
			InvokeRepeating ("RsetHE", after, speed);


		else if(tipoW == 3)
			InvokeRepeating ("RsetHD", after, speed);

		else if(tipoW == 4)
			InvokeRepeating ("RsetVE", after, speed);

		else if(tipoW == 5)
			InvokeRepeating ("RsetVD", after, speed);

	
	}
		
	IEnumerator  end(float tempo){
	
		yield return new WaitForSeconds (tempo);
			
		if (tipoW == 1) {
			CancelInvoke ("RsetHf");
			Destroy (gameObject);
		} else if (tipoW == 2) {
			CancelInvoke ("RsetHE");
			Destroy (gameObject);
		} else if (tipoW == 3) {
			CancelInvoke ("RsetHD");
		
			Destroy (gameObject);

		} else if (tipoW == 4) {
			CancelInvoke ("RsetVE");
			Destroy (gameObject);
		} else if (tipoW == 5) {
			CancelInvoke ("RsetVD");
			Destroy (gameObject);
		}

	
	}
	// Update is called once per frame



		

			















	void RsetHF(){

		if (sort == 2 && aux == 0) {
			tipoBala = 1;
			aux = 1;
		}

		else if (sort == 2 && aux == 1) {
			tipoBala = 2;
			aux = 0;
		}

		if (sort == 3 && aux == 0) {
			tipoBala = 2;
			aux = 1;
		}

		else if (sort == 3 && aux == 1) {
			tipoBala = 3;
			aux = 0;
		}


		for (int i = -80; i < 85; i += 5) {


		


			if (tipoBala == 1) {
				GameObject ins = Instantiate (balaM, new Vector3 (i, 0, 60), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = -1;

			}





			if (tipoBala == 2) {
				GameObject ins = Instantiate (balaC, new Vector3 (i, 0, 60), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = -1;

			}
			if (tipoBala == 3) {
				GameObject ins = Instantiate (balaG, new Vector3 (i, 0, 60), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = -1;

			}
			if (tipoBala == 4) {
				GameObject ins = Instantiate (balaV, new Vector3 (i, 0, 60), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = -1;



			}
		}

	}








	void RsetHD(){
		if (sort == 2 && aux == 0) {
			tipoBala = 1;
			aux = 1;
		}

		else if (sort == 2 && aux == 1) {
			tipoBala = 2;
			aux = 0;
		}

		if (sort == 3 && aux == 0) {
			tipoBala = 2;
			aux = 1;
		}

		else if (sort == 3 && aux == 1) {
			tipoBala = 3;
			aux = 0;
		}

		for (int i = -80; i < 85; i += 5) {

			if (tipoBala == 1) {
				GameObject ins = Instantiate (balaM, new Vector3 (100, 0, i), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = 1;

			}
			if (tipoBala == 2) {
				GameObject ins = Instantiate (balaC, new Vector3 (100, 0, i), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = 1;

			}
			if (tipoBala == 3) {
				GameObject ins = Instantiate (balaG, new Vector3 (100, 0, i), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = 1;

			}
			if (tipoBala == 4) {
				GameObject ins = Instantiate (balaV, new Vector3 (100, 0, i), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = 1;



			}
		}

	}






	void RsetHE(){

		if (sort == 2 && aux == 0) {
			tipoBala = 1;
			aux = 1;
		}

		else if (sort == 2 && aux == 1) {
			tipoBala = 2;
			aux = 0;
		}

		if (sort == 3 && aux == 0) {
			tipoBala = 2;
			aux = 1;
		}

		else if (sort == 3 && aux == 1) {
			tipoBala = 3;
			aux = 0;
		}




		for (int i = -80; i < 85; i += 5) {

			if (tipoBala == 1) {
				GameObject ins = Instantiate (balaM, new Vector3 (-100, 0, i), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = 2;

			}
			if (tipoBala == 2) {
				GameObject ins = Instantiate (balaC, new Vector3 (-100, 0, i), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = 2;

			}
			if (tipoBala == 3) {
				GameObject ins = Instantiate (balaG, new Vector3 (-100, 0, i), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = 2;

			}
			if (tipoBala == 4) {
				GameObject ins = Instantiate (balaV, new Vector3 (-100, 0, i), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = 2;



			}
		}

	}










	void RsetVD(){

		if (sort == 2 && aux == 0) {
			tipoBala = 1;
			aux = 1;
		}

		else if (sort == 2 && aux == 1) {
			tipoBala = 2;
			aux = 0;
		}

		if (sort == 3 && aux == 0) {
			tipoBala = 2;
			aux = 1;
		}

		else if (sort == 3 && aux == 1) {
			tipoBala = 3;
			aux = 0;
		}
		for (int i = -40; i < 85; i += 5) {

			if (tipoBala == 1) {
				GameObject ins = Instantiate (balaM, new Vector3 (i, 0, 60), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = 3;

			}
			if (tipoBala == 2) {
				GameObject ins = Instantiate (balaC, new Vector3 (i, 0, 60), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = 3;

			}
			if (tipoBala == 3) {
				GameObject ins = Instantiate (balaG, new Vector3 (i, 0, 60), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = 3;

			}
			if (tipoBala == 4) {
				GameObject ins = Instantiate (balaV, new Vector3 (i, 0, 60), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = 3;



			}
		}

	}


	void RsetVE(){

		if (sort == 2 && aux == 0) {
			tipoBala = 1;
			aux = 1;
		}

		else if (sort == 2 && aux == 1) {
			tipoBala = 2;
			aux = 0;
		}

		if (sort == 3 && aux == 0) {
			tipoBala = 2;
			aux = 1;
		}

		else if (sort == 3 && aux == 1) {
			tipoBala = 3;
			aux = 0;
		}
		for (int i = -80; i < 45; i += 5) {

			if (tipoBala == 1) {
				GameObject ins = Instantiate (balaM, new Vector3 (i, 0, 60), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = 4;

			}
			if (tipoBala == 2) {
				GameObject ins = Instantiate (balaC, new Vector3 (i, 0, 60), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = 4;

			}
			if (tipoBala == 3) {
				GameObject ins = Instantiate (balaG, new Vector3 (i, 0, 60), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = 4;

			}
			if (tipoBala == 4) {
				GameObject ins = Instantiate (balaV, new Vector3 (i, 0, 60), transform.rotation) as GameObject;
				ins.GetComponent<BasicAtack> ().dir = 4;



			}
		}

	}




	}

