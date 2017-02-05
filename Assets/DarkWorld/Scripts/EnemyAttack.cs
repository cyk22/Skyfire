using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

	public float timeBetweenAttacks = 0.5f;
	public int attackDamage=10;


	Animator anim;
	GameObject player;
	PlayerHealth playerHealth;  //Reference to player's health
	EnemyHealth enemyHealth;   //Reference to enemy's health
	bool playerInRange;
	float timer;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent<PlayerHealth> ();
		enemyHealth = GetComponent<EnemyHealth>();
		anim = GetComponent<Animator> ();
	}


	void OnTriggerEnter(Collider other)
	{
		//if the entering collider is the player
		if (other.gameObject == player) 
		{
			//The player is in range
			playerInRange=true;

		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject == player) 
		{
			playerInRange = false;
		}
	}


	// Update is called once per frame
	void Update () {
		//Add the time since Update was last called to the timer
		timer += Time.deltaTime;

		//if the timer exceeds the time between attacks, the player is in range and this enemy is alive
		if (timer >= timeBetweenAttacks && playerInRange && enemyHealth.currentHealth > 0) 
		{
			Attack ();
		}

		if (playerHealth.currentHealth <= 0) 
		{
			anim.SetTrigger ("playerDead");
		}
	}

	void Attack()
	{
		timer = 0f;

		if (playerHealth.currentHealth > 0) 
		{
			playerHealth.TakeDamage (attackDamage);
		}
	}

}
