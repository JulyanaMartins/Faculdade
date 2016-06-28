using UnityEngine;
using System.Collections;

public class BossControll : MonoBehaviour {
	int velocidade;
	int spot;
	Vector3 b;
	public Rigidbody rb;
	float lasta;
	public Vector3 target;
	// Use this for initialization
	void Start () {
		
target = new Vector3 (0, 0, 20);
		Vector3 dir = (target - transform.position).normalized * 10f;
	
		lasta = Mathf.Infinity;
		b = dir;

	}
	
	void Update(){


		float a = (target - transform.position).sqrMagnitude;
		if (a > lasta)
			b = Vector3.zero;

		lasta = a;
	
	}





	void FixedUpdate(){
		rb = transform.GetComponent<Rigidbody> ();
		rb.velocity = b;

	}

}


