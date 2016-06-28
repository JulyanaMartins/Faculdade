using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class inffm : MonoBehaviour {
	public GameObject Aura;
	public bool a = false;
	//public GameObject May;
	Text conteudo;

	// Use this for initialization
	void Start () {
		conteudo = GetComponent<Text>();

		conteudo.text = ("0");

	}

	// Update is called once per frame
	void Update () {

		if(a == true)

		conteudo.text = Aura.GetComponent<AuraMay> ().Magenta.ToString ();

	

	}
}