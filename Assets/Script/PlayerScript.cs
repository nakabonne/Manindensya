using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	 
	Animator animator;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			animator.SetBool ("Attack2", true);

		}
		if (Input.GetKeyUp (KeyCode.UpArrow)) {
			animator.SetBool ("Attack2", false);
		}
	//上のは二つは今んところいらない
	}


}
//てかこのスクリプト使ってない