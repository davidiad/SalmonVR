﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SwimStateScript : StateMachineBehaviour {

	private GameObject fish;
	private float moveSpeed = 0.0f;
	//public Slider speedSlider;

	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		
		fish = animator.gameObject;
		fish.GetComponent<Rigidbody> ().isKinematic = true;
	}
		
	/*
 	 //OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
	{
		Vector3 moveDirection = new Vector3();
		moveDirection = fish.transform.forward + 0.06f * fish.GetComponent<FishAni> ().chdir;
		moveDirection.Normalize();

		Quaternion rot = Quaternion.LookRotation(moveDirection);

		Vector3 movement = new Vector3();
		movement = fish.transform.forward * moveSpeed;
		fish.transform.localPosition += movement; // should be using movePosition() so it's not "teleporting", and the physics engine is aware of it.


	}
		*/
	

	public void updateMoveSpeed()
	{
		
		//Slider moveSpeedSlider = GetComponent<Slider>();
		//moveSpeedSlider = GameObject.Find("MoveSpeedSlider");
		//moveSpeed = speedSlider.value;
	}
}