using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour 
{
	public int enemyHP = 3;
	public GameObject deathEffect;
	public GameObject spark;
	public Transform target;
	NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
	    //playerを追いかける
		agent.SetDestination(target.position);
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "sumaho")
		{
			enemyHP -= 1;
			Instantiate (spark, transform.position, Quaternion.identity);

			if (enemyHP <= 0) 
			{
				//爆発する
				Instantiate (deathEffect, transform.position, Quaternion.identity);
				Destroy (this.gameObject);
			}
		}
	}


}
