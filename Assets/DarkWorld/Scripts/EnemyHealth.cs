using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
	public int startingHealth = 10;
	public int enemyCurrentHealth;
	public GameObject enemyHealthBar;

	Animator anim;
	bool isDead;



	void Awake ()
	{
		anim = GetComponent <Animator> ();
		enemyCurrentHealth = startingHealth;
	}


	void Update ()
	{
		
	}


	public void eTakeDamage (int amount)
	{
		if(isDead)
			return;

		enemyCurrentHealth -= amount;

		//EnemyHealthSlider.value = enemyCurrentHealth;

		float calHealth = enemyCurrentHealth / startingHealth;

		SetBar (calHealth);

		if(enemyCurrentHealth <= 0 && isDead!=true)
		{
			Death ();
		}
	}


	void Death ()
	{
		isDead = true;
		anim.SetBool("Dead",true);
	}

	public void SetBar(float myHealth)
	{
		enemyHealthBar.transform.localScale = new Vector3 (myHealth, enemyHealthBar.transform.localScale.y, enemyHealthBar.transform.localScale.z);
	}



}
