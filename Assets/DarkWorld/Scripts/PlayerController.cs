using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float maxSpeed=10f;
	bool facingRight=true;


	Animator anim;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float move = Input.GetAxis ("Horizontal");

		anim.SetFloat ("Speed", Mathf.Abs (move));

		GetComponent<Rigidbody2D>().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

		if (move > 0 && !facingRight) {
			Flip ();
		} else if(move <0 && facingRight){
			Flip ();
		}

		//if (GetComponent<Rigidbody2D>().position.x <= -6.5f) {
		//	GetComponent<Rigidbody2D>().position = new Vector2(-6.5f, GetComponent<Rigidbody2D>().position.y);
		//} else if (GetComponent<Rigidbody2D>().position.x >= 11f) {
		//	GetComponent<Rigidbody2D>().position = new Vector2(11f, GetComponent<Rigidbody2D>().position.y);
		//}

	}

	void Flip()
	{
		facingRight = !facingRight;
		Vector2 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
