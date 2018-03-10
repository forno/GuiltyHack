using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefavForm : MonoBehaviour {
	public float spawn_interval;

	public GameObject instance;
	public GameObject YakkaiP;

	private IEnumerator coroutine;


	void Start () {
		coroutine = instant();
		StartCoroutine (coroutine);
	}

	private IEnumerator instant(){
		while (true) {
			GameObject prefav = (GameObject)Instantiate (YakkaiP, instance.transform.position, Quaternion.identity);
			prefav.transform.SetParent (instance.transform, false);
			yield return new WaitForSeconds (spawn_interval);
		}
	}
}
