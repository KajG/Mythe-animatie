using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour {

	private Animator animator;
	private double inc;
	public float speed;
	AnimatorClipInfo[] animClip;
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	void Update () {
		if (inc <= 0) {
			inc = 0;
		}
		if(inc >= 1.292f){
			inc = 1.292f;
		}
		if (Input.GetKey (KeyCode.Space)) {
			inc += speed / 100;
			animator.SetTime (inc);
		} else {
			inc -= speed / 100;
			animator.SetTime (inc);
		}
	}
}
