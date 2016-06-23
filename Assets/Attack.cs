using UnityEngine;
using System.Collections;

public class Attack : StateMachineBehaviour {

	GameObject player;
	WarriorAnimationDemoFREE script;
    // OnStateEnter is called before OnStateEnter is called on any state inside this state machine
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		if (player == null) 
		{
			player = GameObject.FindGameObjectWithTag ("Player2");
			script = player.GetComponent<WarriorAnimationDemoFREE> ();
		}
	}

	// OnStateUpdate is called before OnStateUpdate is called on any state inside this state machine
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		if (player == null) 
		{
			player = GameObject.FindGameObjectWithTag ("Player2");
			script = player.GetComponent<WarriorAnimationDemoFREE> ();
		}
	}

	// OnStateExit is called before OnStateExit is called on any state inside this state machine
	//アニメーションが終わった時
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
	{
		if (script != null) {
			Debug.Log ("アニメーション終了");
			script.OffSentanCollider ();
		}
		//player.SendMessage ("OffSentanCollider");
	}

	// OnStateMove is called before OnStateMove is called on any state inside this state machine
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called before OnStateIK is called on any state inside this state machine
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateMachineEnter is called when entering a statemachine via its Entry Node
	//override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash){
	//
	//}

	// OnStateMachineExit is called when exiting a statemachine via its Exit Node
	//override public void OnStateMachineExit(Animator animator, int stateMachinePathHash) {
	//
	//}
}
