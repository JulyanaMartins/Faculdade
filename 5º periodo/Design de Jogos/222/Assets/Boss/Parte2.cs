using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Parte2 : MonoBehaviour {
	public GameObject Wave;
	public GameObject Laser;
	GameObject ins;
	public GameObject DimensionalBM;
	public GameObject DimensionalBMe;
	public GameObject DimensionalBC;
	public GameObject DimensionalBG;
	List<GameObject> insLaser= new List<GameObject>();
	// Use this for initialization
	void Start () {
	
		StartCoroutine (E01 (14.5f));

		StartCoroutine (E02 (14.5f));

		StartCoroutine (E03 (16f));

		StartCoroutine (E04 (16f));

		StartCoroutine (E05 (16.5f));

		StartCoroutine (E06 (16.5f));




		StartCoroutine (E07 (17f));


		StartCoroutine (E08 (17.5f));

		StartCoroutine (E09 (20f));


		StartCoroutine (E10 (22f));

		StartCoroutine (E11 (24f));
		StartCoroutine (E12 (25f));
		StartCoroutine (E13 (26f));
		StartCoroutine (E14 (27f));



	}
	
	IEnumerator E01(float after){
		yield return new WaitForSeconds (after);
		ins = Instantiate (Wave) as GameObject;
		ins.GetComponent<HwaveD>().after = 0.1f;
		ins.GetComponent<HwaveD>().tipoBala = 2;
		ins.GetComponent<HwaveD>().on = true;
		ins.GetComponent<HwaveD>().tipoW = 5;
		ins.GetComponent<HwaveD>().speed = 0.1f;
		ins.GetComponent<HwaveD>().tempo = 0.5f;
		ins.GetComponent<HwaveD> ().sort = 0;
	}


	IEnumerator E02(float after){
		yield return new WaitForSeconds (after);
		ins = Instantiate (Wave) as GameObject;
		ins.GetComponent<HwaveD>().after = 0.1f;
		ins.GetComponent<HwaveD>().tipoBala = 3;
		ins.GetComponent<HwaveD>().on = true;
		ins.GetComponent<HwaveD>().tipoW = 4;
		ins.GetComponent<HwaveD>().speed = 0.1f;
		ins.GetComponent<HwaveD>().tempo = 0.5f;
		ins.GetComponent<HwaveD> ().sort = 0;

	}



	IEnumerator E03(float after){
		yield return new WaitForSeconds (after);
		insLaser.Add( Instantiate (Laser) as GameObject);
		insLaser[0].GetComponent<ControlLaser> ().dir = new Vector3(90,0,-30);
		insLaser[0].GetComponent<ControlLaser> ().tipoLaiser = 1;
	
		StartCoroutine (killLaser(insLaser[0]));
	}

	IEnumerator E04(float after){
		yield return new WaitForSeconds (after);
		insLaser.Add( Instantiate (Laser) as GameObject);
		insLaser[1].GetComponent<ControlLaser> ().dir = new Vector3(-90,0,30);
		insLaser[1].GetComponent<ControlLaser> ().tipoLaiser = 2;

		StartCoroutine (killLaser(insLaser[1]));
	}

	IEnumerator E05(float after){
		yield return new WaitForSeconds (after);
		insLaser.Add( Instantiate (Laser) as GameObject);
		insLaser[2].GetComponent<ControlLaser> ().dir = new Vector3(40,0,50);
		insLaser[2].GetComponent<ControlLaser> ().tipoLaiser = 3;
		StartCoroutine (killLaser(insLaser[2]));

	}

	IEnumerator E06(float after){
		yield return new WaitForSeconds (after);
		insLaser.Add( Instantiate (Laser) as GameObject);
		insLaser[3].GetComponent<ControlLaser> ().dir = new Vector3(-40,0,-50);
		insLaser[3].GetComponent<ControlLaser> ().tipoLaiser = 4;
		StartCoroutine (killLaser(insLaser[3]));

	}


	IEnumerator E07(float after){
		yield return new WaitForSeconds (after);
		ins = Instantiate (Wave) as GameObject;
		ins.GetComponent<HwaveD>().after = 0.1f;
		ins.GetComponent<HwaveD>().tipoBala = 3;
		ins.GetComponent<HwaveD>().on = true;
		ins.GetComponent<HwaveD>().tipoW = 3;
		ins.GetComponent<HwaveD>().speed = 0.05f;
		ins.GetComponent<HwaveD>().tempo = 0.6f;
		ins.GetComponent<HwaveD> ().sort = 0;
	}

	IEnumerator E08(float after){
		yield return new WaitForSeconds (after);
			ins = Instantiate (Wave) as GameObject;
			ins.GetComponent<HwaveD> ().after = 0.1f;
			ins.GetComponent<HwaveD> ().tipoBala = 1;
			ins.GetComponent<HwaveD> ().on = true;
			ins.GetComponent<HwaveD> ().tipoW = 1;
			ins.GetComponent<HwaveD> ().speed = 0.27f;
			ins.GetComponent<HwaveD> ().tempo = 2f;
			ins.GetComponent<HwaveD> ().sort = 2;
		
	}


	IEnumerator E09(float after){
		yield return new WaitForSeconds (after);
		ins = Instantiate (Wave) as GameObject;
		ins.GetComponent<HwaveD> ().after = 0.1f;
		ins.GetComponent<HwaveD> ().tipoBala = 3;
		ins.GetComponent<HwaveD> ().on = true;
		ins.GetComponent<HwaveD> ().tipoW = 2;
		ins.GetComponent<HwaveD> ().speed = 0.2f;
		ins.GetComponent<HwaveD> ().tempo = 1f;
		ins.GetComponent<HwaveD> ().sort = 3;

	}


	IEnumerator E10(float after){
		yield return new WaitForSeconds (after);
		ins = Instantiate (Wave) as GameObject;
		ins.GetComponent<HwaveD> ().after = 0.1f;
		ins.GetComponent<HwaveD> ().tipoBala = 3;
		ins.GetComponent<HwaveD> ().on = true;
		ins.GetComponent<HwaveD> ().tipoW = 3;
		ins.GetComponent<HwaveD> ().speed = 0.2f;
		ins.GetComponent<HwaveD> ().tempo = 1f;
		ins.GetComponent<HwaveD> ().sort = 2;

	}

	IEnumerator E11(float after){
		yield return new WaitForSeconds (after);
		ins = Instantiate (DimensionalBM) as GameObject;


	}

	IEnumerator E12(float after){
		yield return new WaitForSeconds (after);
		ins = Instantiate (DimensionalBC) as GameObject;


	}


	IEnumerator E13(float after){
		yield return new WaitForSeconds (after);
		ins = Instantiate (DimensionalBG) as GameObject;


	}


	IEnumerator E14(float after){
		yield return new WaitForSeconds (after);
		ins = Instantiate (DimensionalBMe) as GameObject;


	}


	IEnumerator killLaser(GameObject inss){

		yield return new WaitForSeconds (5f);
		Destroy (inss);

	}
}
