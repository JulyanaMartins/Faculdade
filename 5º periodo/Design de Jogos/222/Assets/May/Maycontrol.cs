using UnityEngine;
using System.Collections;

public class Maycontrol : MonoBehaviour {
	int velocidade;
	public  int change_cor;
	public Transform Maypos;
	public bool fine = false;
	public int vida;
	public GameObject Aura;
	public GameObject LifeBar;
	public GameObject FailAnimation;
	GameObject ins;
	int aux = 0;

	public AudioClip crashSoft;


	private AudioSource source;




	// Use this for initialization
	void Start () {
		ins = Instantiate (FailAnimation) as GameObject;
		velocidade = 2;
		change_cor = 0;
		Maypos = transform;
		aux = 0;

	}


	
	// Update is called once per frame
	void Update () {
		Aura = GameObject.Find ("AuraMay");
		change_cor = 0;
		Maypos = transform;

		print (vida);

		 if(vida <= 0) {	
			gameObject.GetComponent<BoxCollider> ().enabled = false;
			gameObject.GetComponent<MeshRenderer> ().enabled = false;
			fine = false;
		}



		if (Input.GetKey (KeyCode.UpArrow)) 
			transform.Translate (0, 0, velocidade);


		

		if (Input.GetKey (KeyCode.DownArrow))
			transform.Translate (0, 0, -velocidade);


		if (Input.GetKey (KeyCode.RightArrow))
			transform.Translate (velocidade, 0, 0);


		if (Input.GetKey (KeyCode.LeftArrow))
			transform.Translate (-velocidade, 0, 0);



		if (Input.GetKey (KeyCode.Z)) 
			change_cor = 1;

		


		if (Input.GetKey (KeyCode.X))
			change_cor = 2;



		if (Input.GetKey (KeyCode.C))
			change_cor = 3;

		}

	void OnCollisionEnter(Collision c){

		if (c.gameObject.tag == "BasicAtack") {
			
			die();
		}




	}


	void Awake () {

		source = GetComponent<AudioSource>();
	}


	public void die(){
		//Destroy(gameObject);
		if (vida > 0) {
			Aura.GetComponent<SphereCollider> ().enabled = false;
			gameObject.GetComponent<BoxCollider> ().enabled = false;
			//gameObject.GetComponent<MeshRenderer> ().enabled = false;
			LifeBar.GetComponent<LifeBar> ().setBar ();
			vida--;
			//InvokeRepeating ("invulneravel", 0.2f, 0.1f);
			StartCoroutine (stopInv ());
			source.PlayOneShot(crashSoft,1);
			ins.GetComponent<FailAnim> ().EnableFail ();
		}
		else if(vida <= 0) {	
			gameObject.GetComponent<BoxCollider> ().enabled = false;
			//gameObject.GetComponent<MeshRenderer> ().enabled = false;

			Aura.GetComponent<SphereCollider> ().enabled = false;
		fine = false;
		}
	
	}

	void invulneravel(){
		
		if (aux == 0) {
			gameObject.GetComponent<MeshRenderer> ().enabled = true;
			Aura.GetComponent<MeshRenderer> ().enabled = true;
			aux = 1;
		}

		else if (aux == 1) {
			gameObject.GetComponent<MeshRenderer> ().enabled = false;

			aux = 0;
		}
	
	}

	IEnumerator stopInv(){
		yield return new WaitForSeconds (0.2f);
		//CancelInvoke ("invulneravel");
		//gameObject.GetComponent<MeshRenderer> ().enabled = true;
		gameObject.GetComponent<BoxCollider> ().enabled = true;
		Aura.GetComponent<SphereCollider> ().enabled = true;
	}
}

