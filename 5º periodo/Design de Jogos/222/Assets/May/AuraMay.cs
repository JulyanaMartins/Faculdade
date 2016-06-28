using UnityEngine;
using System.Collections;

public class AuraMay : MonoBehaviour {

	//public GameObject a;
	// Use this for initialization

	 Color32 cor0;

	 Color32 cor1;

	 Color32 cor2;

	 Color32 cor3;

	 public static int cor;

	public int Magenta;
	public int Ciano ;
	public int Gold ;

	public GameObject May;

	void Start () {

		cor = 0;
		cor0 = new Color32 (255,0,255,0);

		cor1 = new Color32 (255,0,255,130);

		cor2 = new Color32 (0,255,255, 130);

		cor3 = new Color32 (255,255,0,136);

		Gold = 0;
		Magenta = 0;
		Ciano = 0;
	

	}
	
	// Update is called once per frame
	void Update () {
			//int c = a.GetComponent<Maycontrol> ().change;
		if (May.GetComponent<Maycontrol> ().fine == true) {

			if (May.GetComponent<Maycontrol> ().change_cor == 0) {
				setAura (cor0, true);
				gameObject.GetComponent<SphereCollider> ().isTrigger = true;
				May.GetComponent<BoxCollider> ().isTrigger = false;

				cor = 0;
			}

			if (May.GetComponent<Maycontrol> ().change_cor == 1) {
				setAura (cor1, false);
				gameObject.GetComponent<SphereCollider> ().isTrigger = false;
				May.GetComponent<BoxCollider> ().isTrigger = true;
				cor = 1;
			}


			if (May.GetComponent<Maycontrol> ().change_cor == 2) {
				setAura (cor2, false);
				gameObject.GetComponent<SphereCollider> ().isTrigger = false;
				May.GetComponent<BoxCollider> ().isTrigger = true;
				cor = 2;
			}



			if (May.GetComponent<Maycontrol> ().change_cor == 3) {
				setAura (cor3, false);
				gameObject.GetComponent<SphereCollider> ().isTrigger = false;
				May.GetComponent<BoxCollider> ().isTrigger = true;
				cor = 3;
			}
		} else {
		
			setAura (cor0, true);
			gameObject.GetComponent<SphereCollider> ().isTrigger = true;
			May.GetComponent<BoxCollider> ().isTrigger = true;

			cor = 0;
		}
		




		
		


		}
	



	public void setAura(Color cor, bool des){
		GetComponent<Renderer> ().material.color = cor;
		Behaviour h = (Behaviour)GetComponent ("Halo");
		if (des)
			h.enabled = false;
		else
			h.enabled = true;
			

	}

	void OnCollisionEnter(Collision c){

		if(c.gameObject.tag == "BasicAtack"){

			if (cor == 1 && c.gameObject.name != "BasicAtackM(Clone)") 
				

				May.GetComponent<Maycontrol> ().die ();
			
			else if (cor == 1 && c.gameObject.name == "BasicAtackM(Clone)")
				Magenta++;
				
				
		
			if (cor == 2 && c.gameObject.name != "BasicAtackC(Clone)") 


				May.GetComponent<Maycontrol> ().die ();
			
			else if (cor == 2 && c.gameObject.name == "BasicAtackC(Clone)")
				Ciano++;

			if (cor == 3 && c.gameObject.name != "BasicAtackG(Clone)") 
				

				May.GetComponent<Maycontrol> ().die ();

			else if (cor == 3 && c.gameObject.name == "BasicAtackG(Clone)")
				Gold++;

}
			
}
}