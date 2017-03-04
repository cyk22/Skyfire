﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public int startingHealth=5;
	public int currentHealth;
	public GameObject PlayerHealthBar;



	Animator anim;
	GameObject enemy;
	PlayerAttack playerAttack;   //Reference to the Animator component
	EnemyAttack enemyAttack;  //Reference to the PlayerShotting script
	PlayerHealth playerHealth;
	PlayerController playerController;

	bool isDead=false;
	bool damaged;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		currentHealth = startingHealth;
		//enemy = GameObject.FindGameObjectsWithTag ("Enemy");
		playerHealth = GetComponent<PlayerHealth> ();
		playerAttack = GetComponent<PlayerAttack> ();
		enemyAttack = enemy.GetComponent<EnemyAttack> ();
	}
	
	// Update is called once per frame
	void Update () {




	}

	public void TakeDamage(int amount)
	{
		//set the damaged flag so the screen will flash
		damaged = true;

		//Reduce the current health by damage amount;
		currentHealth -=amount;

		//Set the health bar's value to the current health
		//PlayerHealthSlider.value=currentHealth;

		if(currentHealth<=0 && isDead!=true)
		{
			Death();
		}
	}

	void Death()
	{
		//Set the death flag so this function won't be called again
		isDead = true;

		//Turn off any remaining shooting effects.
		//PlayerShooting.DisableEffects();

		//Tell the animator that the player is dead
		anim.SetBool("Dead",true);
//		anim.SetBool ("Idle", false);
//		anim.SetBool ("Walk", false);
//		anim.SetBool ("Attack", false);

//		playerAttack.enabled = false;
//		enemyAttack.enabled = false;
//		playerHealth.enabled = false;
//		playerController.enabled = false;

	}
}
