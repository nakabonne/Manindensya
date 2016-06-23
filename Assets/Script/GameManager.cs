using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;


	public float highScore = 0;
	public int enemycount = 0;




	void Awake()
	{
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (this.gameObject);
		} else {
			Destroy (this.gameObject);
		}


	}
	//ハイスコアの記録を初期化
	public void Clear(){
		highScore = 0.0f;
		PlayerPrefs.SetFloat("HIGHSCORE",0.0f);
	}
	public void Load(){
		highScore = PlayerPrefs.GetFloat ("HIGHSCORE");
	}
	public void Save(){
		PlayerPrefs.SetFloat("HIGHSCORE",highScore);
	}
	//ハイスコアの記録を更新する
	public void SetScore(float myScore){
		if (!PlayerPrefs.HasKey ("HIGHSCORE")) {
			Clear ();
		}
		Load();
		if(myScore > highScore){
			highScore = myScore;
		}
		Save();
	}
}