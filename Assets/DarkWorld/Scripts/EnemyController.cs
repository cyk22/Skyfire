using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour {



	public float MoveSpeed;
	public float MinDist;
	GameObject enemy;
	GameObject player;
	//Transform transform;

	Animator anim;

	// Use this for initialization
	void Start () {
		enemy = this.gameObject;

		player = GameObject.FindGameObjectWithTag ("Player");

//		enemy = GameObject.FindGameObjectWithTag ("Enemy");

		//transform = GetComponent<Transform> ();

		anim = GetComponent<Animator> ();

		MinDist = 2f;

		MoveSpeed = 1f;


	}
	
	// Update is called once per frame
	void Update ()
	{
		//if (GetComponent<Rigidbody2D> ().position.x <= -6.5f) {
		//	GetComponent<Rigidbody2D> ().position = new Vector2 (-6.5f, GetComponent<Rigidbody2D> ().position.y);
		//} else if (GetComponent<Rigidbody2D> ().position.x >= 10f) {
		//	GetComponent<Rigidbody2D> ().position = new Vector2 (10f, GetComponent<Rigidbody2D> ().position.y);
		//}

		if (enemy.transform.position.x - player.transform.position.x >= MinDist) {

			Vector3 dir = new Vector3 ((player.transform.position.x - enemy.transform.position.x), 0, 0);
			
			enemy.transform.position += dir/dir.magnitude * MoveSpeed * Time.deltaTime;
			anim.SetTrigger ("Walk");
		} else {
			anim.SetBool ("Attack",true);
		}




	}


}
