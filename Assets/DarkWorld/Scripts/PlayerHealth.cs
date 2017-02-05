using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public int startingHealth=100;
	public int currentHealth;
	public Slider PlayerHealthSlider;
	public ImagePosition damageImage;
	public float flashSpeed;
	public Color flashColor = new Color (1f, 0f, 0f, 0.1f);


	Animator anim;
	//PlayerMovement playerMovement;   //Reference to the Animator component
	//PlayerShooting playerShooting;  //Reference to the PlayerShotting script

	Escape escape;
	Animator escapeAnim;

	bool isDead;
	bool damaged;


	// Use this for initialization
	void Start () {
		currentHealth = startingHealth;
		//escapeAnim = GetComponent<Escape>;
	}
	
	// Update is called once per frame
	void Update () {
		if (currentHealth <= 0) 
		{
			escapeAnim.SetBool ("Failed", true);
		}
	}

	public void TakeDamage(int amount)
	{
		//set the damaged flag so the screen will flash
		damaged = true;

		//Reduce the current health by damage amount;
		currentHealth -=amount;

		//Set the health bar's value to the current health
		PlayerHealthSlider.value=currentHealth;

		if(currentHealth<=0 && !isDead)
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
		anim.SetTrigger("Die");

		//playerMovement.enabled = false;
		//PlayerShooting.enabled = false;

	}
}
