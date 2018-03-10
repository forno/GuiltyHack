using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	//オブジェクト参照
	public GameObject gameObjectPolice;			//ポリス

	//タグ定義
	private const string TAG_TROUBLE = "Trouble";	//タグ：厄介
	private const string TAG_FAN = "Fan";		//タグ：ノーマルファン

	//メンバ変数



	public void PunishAction(){
		GameObject tmpObj = gameObjectPolice.GetComponent<PoliceManager>().GetColObject();

		if(tmpObj == null){return;}

		if(tmpObj.tag == TAG_TROUBLE){
			//厄介を取り締まる
			gameObjectPolice.GetComponent<PoliceManager>().DeleteObject();
		}
		if(tmpObj.tag == TAG_FAN){
			//ファンを取り締まる
		}
	}

}



/*
判定に入る
↓
判定内に取り締まり対象(厄介・ファン問わず)いればアクションを起こす・判定内に対象がいなければ処理終了
↓
判定対象が厄介ならデストロイ・ファンならペナルティ
↓

 */