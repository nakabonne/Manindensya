using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TitleScript : MonoBehaviour 
{
	public Text highScoreLabel;

	// Use this for initialization
	void Start () {
		highScoreLabel.text = GameManager.instance.highScore.ToString();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
