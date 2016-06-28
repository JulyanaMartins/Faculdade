using UnityEngine;
using System.Collections;

public class BasicAtack : MonoBehaviour {
	public Rigidbody rb;
	public float speed;
	public float lifetime ;
	public int dir = 0;
	// Use this for initialization
	void Start () {
		rb = transform.GetComponent<Rigidbody> ();
		speed = 60.0f;

	}
	

	void Update () {

		if (dir == -1)
			rb.AddForce (Vector3.back *80);

		if (dir == 0)
			rb.velocity = transform.forward * speed;
		else if (dir == 1)
			rb.AddForce (Vector2.left * 250);
		else if (dir == 2)
			rb.AddForce (Vector2.right * 80);
		else if (dir == 3) {
			rb.AddForce (Vector2.right * 80);
			rb.AddForce (Vector3.back * 80);
		}

		else if (dir == 4) {
			rb.AddForce (Vector2.left * 80);
			rb.AddForce (Vector3.back * 80);
		}



	}




	void  Awake ()
	{
		lifetime = 5.0f;
		Destroy(gameObject, lifetime);	
	}


	void OnCollisionEnter(Collision c){

		if(c.gameObject.tag == "Player"){
			Destroy(gameObject);
		}

}



}
