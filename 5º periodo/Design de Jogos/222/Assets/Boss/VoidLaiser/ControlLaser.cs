using UnityEngine;
using System.Collections;

public class ControlLaser : MonoBehaviour {
	public GameObject VoidLaiserD;

	public GameObject VoidLaiserE;

	public GameObject VoidLaiserS;

	public GameObject VoidLaiserI;

	public int tipoLaiser;
	public Vector3 dir;
	GameObject ins;

	// Use this for initialization
	void Start () {

		//dir = new Vector3(-90,0,0);
		//dir = new Vector3(0,0,-50);

		if (tipoLaiser == 1)
			ins = Instantiate (VoidLaiserD, dir, VoidLaiserD.transform.rotation) as GameObject;
		else if (tipoLaiser == 2)
			ins = Instantiate (VoidLaiserE, dir, VoidLaiserE.transform.rotation) as GameObject;
		else if (tipoLaiser == 3)
			ins = Instantiate (VoidLaiserS, dir, VoidLaiserS.transform.rotation) as GameObject;
		else if (tipoLaiser == 4)
			ins = Instantiate (VoidLaiserI, dir, VoidLaiserI.transform.rotation) as GameObject;
	

		StartCoroutine (Kill());
	}

	IEnumerator Kill(){
		yield return new WaitForSeconds (5);

		Destroy (ins);
		
	
	}
}
