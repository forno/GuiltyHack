using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	//タグ定義
	private const string TAG_TROUBLE = "";	//タグ：厄介
	private const string TAG_FAN = "";		//タグ：ノーマルファン

	//メンバ変数


	public void PunishAction(){

	}

	private void OnTriggerStay(Collider other) {
		if(/*hogehoge*/){
			if(other.gameObject.tag == TAG_TROUBLE){
				//厄介を取り締まる
			}
			if(other.gameObject.tag == TAG_FAN){
				//(罪の無い)ファンを取り締まる
			}
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