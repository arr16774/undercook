using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	static Animator anim;
	public float speed = 2.0f;
	public float rotationspeed = 75.0f;

	// Use this for initialization
	void Start () {
		anim  = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		float translation = Input.GetAxis("Vertical")*speed;
		float translation2 = Input.GetAxis("Horizontal")*speed;
		translation *= Time.deltaTime;
		translation2 *= Time.deltaTime;
	
		Vector3 movimiento = new Vector3(translation2, 0,translation);

		Quaternion rotate = Quaternion.LookRotation(movimiento);
		rotate *= Quaternion.Euler(0,90,0);
		transform.rotation = Quaternion.Slerp(transform.rotation, rotate,Time.deltaTime*rotationspeed);
		transform.Translate(translation2,0,translation,Space.World);
		

		

		if(translation != 0){

			anim.SetBool("isRunning", true);
		}
		else if(translation2 != 0){
			anim.SetBool("isRunning",true);
		}else{
			anim.SetBool("isRunning",false);

		}
	}
}
