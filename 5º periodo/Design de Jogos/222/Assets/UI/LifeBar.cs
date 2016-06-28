using UnityEngine;
using System.Collections;

public class LifeBar : MonoBehaviour {
	public float Maxlife = 100f;
	public float current_life = 0f;
	public GameObject bar;
	float calcLife;
	// Use this for initialization
	void Start () {
		Maxlife = 100f;
		current_life = Maxlife;
	}
	
	// Update is called once per frame
	public void setBar () {
		current_life = current_life - 20;
		calcLife = current_life / Maxlife;
		bar.transform.localScale = new Vector3 (calcLife,bar.transform.localScale.y, bar.transform.localScale.z);
	}
		
		


	}

