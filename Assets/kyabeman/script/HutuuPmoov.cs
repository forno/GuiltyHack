using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HutuuPmoov : MonoBehaviour {
    public float speed;

	public float moovTime;
	public float moovTimeOut;
	//public GameObject YakkaiP;
	public GameObject HutuuP;

	void Update (){
		moovTime += Time.deltaTime;

		if (moovTime >= 0) {
			transform.position += new Vector3 (speed * Time.deltaTime, 0f, 0f);
		}
		if (moovTime >= moovTimeOut) {

		}
	}

}
