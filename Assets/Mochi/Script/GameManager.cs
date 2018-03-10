using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	//タグ定義
	private const string TAG_TROUBLE = "";	//タグ：厄介
	private const string TAG_FAN = "";		//タグ：ノーマルファン

	//メンバ変数
	private bool enableAction;				//(厄介・ファン問わず)取り締まれるか
	private GameObject colObject;			//判定内に入ったオブジェクト(保管用)


	/*
	private void OnTriggerStay(Collider other) {
		if(hoge){
			if(other.gameObject.tag == TAG_TROUBLE){
				//厄介を取り締まる
			}
			if(other.gameObject.tag == TAG_FAN){
				//(罪の無い)ファンを取り締まる
			}
		}
		hoge = false;
	}
	*/

	private void OnTriggerEnter2D(Collider2D other) {
		//対象が判定内に入った
		colObject = other.gameObject;
		enableAction = true;
	}

	private void OnTriggerExit2D(Collider2D other) {
		//対象が判定から出た
		enableAction = false;
	}


	public void PunishAction(){
		if(!enableAction){return;}

		if(colObject.tag == TAG_TROUBLE){
			//厄介を取り締まる
		}
		if(colObject.tag == TAG_FAN){
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