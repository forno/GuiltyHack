using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class form : MonoBehaviour {

	public GameObject yakkaip;
	public GameObject canvas;

	// Use this for initialization
	void Start () {
		GameObject prefav = (GameObject)Instantiate (yakkaip);
		prefav.transform.SetParent (canvas.transform, false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
