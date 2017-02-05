using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class Escape : MonoBehaviour {


	public float restartDelay = 5f;
	Animator anim;


	float restartTimer;

	void Start()
	{
		anim = GetComponent<Animator>();

	}


	public void clicked()
	{
		Debug.Log ("click!");
		anim.SetBool ("Failed", true);


		//restartTimer += Time.deltaTime;

		//if (restartTimer >= restartDelay)
		//{
		//	Application.LoadLevel ("map");
		//}

	}
}
