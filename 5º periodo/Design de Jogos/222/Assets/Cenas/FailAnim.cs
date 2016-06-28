using UnityEngine;
using System.Collections;

public class FailAnim : MonoBehaviour
{
	void Start(){
		GetComponent<Canvas>().enabled = false;

	}


	public void EnableFail() {
		GetComponent<Canvas>().enabled = true;

		StartCoroutine (Des ());
	}
	IEnumerator Des(){
		yield return new WaitForSeconds (0.3f);

		GetComponent<Canvas>().enabled = true;

		}

	}



