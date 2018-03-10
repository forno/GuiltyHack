using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour {

	//オブジェクト参照
	public GameObject gameObjectPolice;			//ポリス
	public GameObject TextScoreCount;			//テキストスコア

	//タグ定義
	private const string TAG_TROUBLE = "Trouble";	//タグ：厄介
	private const string TAG_FAN = "Fan";		//タグ：ノーマルファン

	//メンバ変数
	private int totalScore = 0;


	public void PunishAction(){
		GameObject tmpObj = gameObjectPolice.GetComponent<PoliceManager>().GetColObject();

		if(tmpObj == null){return;}

		if(tmpObj.tag == TAG_TROUBLE){
			//厄介を取り締まる
			__PunishTrouble();
		}
		if(tmpObj.tag == TAG_FAN){
			__PunishFan();
			//ファンを取り締まる
		}
	}

	private void __PunishTrouble(){
		Debug.Log("厄介取り締まりィ！！");
		//gameObjectPolice.GetComponent<PoliceManager>().DeleteObject();
		AddScore();
		//コンボ加算
	}

	private void __PunishFan(){
		Debug.Log("なんてことを・・・");
		//ペナルティ「ライフ-1」
		//コンボ途切れる
	}

	private void AddScore(){
		totalScore += 100;
		TextScoreCount.GetComponent<TextMeshProUGUI>().text = "" + totalScore;
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