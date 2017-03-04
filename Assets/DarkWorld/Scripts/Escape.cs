//using UnityEngine;
//using System.Collections;
//using UnityEngine.UI;
//using UnityEngine.Events;
//
//public class Escape : MonoBehaviour {
//
//
//	public float restartDelay = 5f;
//	Animator anim;
//	GameObject player;
//	GameObject enemy;
//	GameObject failed;
//
//
//
//	float restartTimer;
//
//	PlayerHealth playerHealth;
//	Animator eneAni;
//	Animator playerAni;
//	Animator failedAni;
//	PlayerAttack playerAttack;   //Reference to the Animator component
//	EnemyAttack enemyAttack;  //Reference to the PlayerShotting script
//	EnemyController enemyController;
//	PlayerController playerController;
//	EnemyHealth enemyhealth;
//
//	void Start()
//	{
//		
//		failed = GameObject.FindGameObjectWithTag ("Failed");
//		player = GameObject.FindGameObjectWithTag ("Player");
//		enemy = GameObject.FindGameObjectWithTag ("Enemy");
//		playerHealth = player.GetComponent<PlayerHealth> ();
//		playerController = player.GetComponent<PlayerController> ();
//		playerAttack = player.GetComponent<PlayerAttack> ();
//		enemyAttack = enemy.GetComponent<EnemyAttack> ();
//		enemyhealth = enemy.GetComponent<EnemyHealth> ();
//
//
//
//		eneAni = enemy.GetComponent<Animator>();
//		playerAni = player.GetComponent<Animator> ();
//		failedAni = failed.GetComponent<Animator> ();
//	}
//
//	void Update()
//	{
//		if (playerHealth.currentHealth <= 0) {
//			failedAni.SetBool ("Failed", true);
//
//			//restartTimer += Time.deltaTime;
//
//			//if (restartTimer >= restartDelay)
//			//{
//			//	Application.LoadLevel ("map");
//			//}
//
//			eneAni.SetTrigger ("Idle");
//		}
//
//		if (enemyhealth.enemyCurrentHealth <= 0) {
//			anim.SetBool ("Victory", true);
//			playerAni.SetTrigger("Idel");
//		}
//	}
//
//	public void clicked()
//	{
//		Debug.Log ("click!");
//		failedAni.SetBool ("Failed", true);
//
//
//		playerAttack.enabled = false;
//		//enemyAttack.enabled = false;
//		playerHealth.enabled = false;
//		enemyController.enabled = false;
//		playerController.enabled = false;
//		//restartTimer += Time.deltaTime;
//
//		//if (restartTimer >= restartDelay)
//		//{
//		//	Application.LoadLevel ("map");
//		//}
//
//	}
//
//
//}
