using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceManager : MonoBehaviour {

	[SerializeField]private GameObject colObject;			//対象のオブジェクト

	//private bool enableAction = false;		//対象が範囲内に入ったかどうか

	private void OnTriggerEnter2D(Collider2D other) {
		colObject = other.gameObject;
		//enableAction = true;
	}

	private void OnTriggerExit2D(Collider2D other) {
		colObject = null;
		//enableAction = false;
	}

	public GameObject GetColObject(){
	
		return colObject;
	}

	public void DeleteObject(){
		Destroy(colObject);
	}

}
