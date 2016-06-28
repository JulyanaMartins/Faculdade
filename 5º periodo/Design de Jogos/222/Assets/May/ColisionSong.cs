using UnityEngine;
using System.Collections;

public class ColisionSong : MonoBehaviour {

	public AudioClip crashSoft;


	private AudioSource source;



	void Awake () {

		source = GetComponent<AudioSource>();
	}


	void OnCollisionEnter (Collision coll)
	{


			source.PlayOneShot(crashSoft,1);

}
}