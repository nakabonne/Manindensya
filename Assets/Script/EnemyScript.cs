using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour 
{
	public int enemyHP = 100;
	public GameObject deathEffect;
	public GameObject spark;
	public Collider colE;
	Transform target;
	NavMeshAgent agent;
	Animator animator;

	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player2").transform;
		agent = GetComponent<NavMeshAgent> ();
		animator = GetComponent<Animator> ();
		colE.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
	    //playerを追いかける
		agent.SetDestination(target.position);


			
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "sentan")
		{
			enemyHP -= 1;
			GameObject instance1 = (GameObject)Instantiate (spark, transform.position, Quaternion.identity);
			Destroy (instance1, 1.5f);


			if (enemyHP <= 0) 
			{
				Destroy (this.gameObject);
				//爆発
				GameObject instance2 = (GameObject)Instantiate (deathEffect, transform.position, Quaternion.identity);

				Destroy (instance2, 1.5f);
				GameManager.instance.enemycount++;


			}
		}
	}

	//Playerのこライダーに侵入いした時に攻撃アニメーション
	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "Player2") {
			animator.SetTrigger ("enemyAttack");
		}
	}

	public void ONEnemySentanCollider()
	{
		colE.enabled = true;
	}

	public void OffEnemySentanCollider()
	{
		colE.enabled = false;
	}
}
