using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private Rigidbody rb;
	[SerializeField] private float speed;
	[SerializeField] private float rotationSpeed;
	[SerializeField] private Animator animator;

	private readonly int hashIdle = Animator.StringToHash("idle");
	private readonly int hashSpeed = Animator.StringToHash("speed");

	
	void Start () {
		rb = GetComponent<Rigidbody>();
		//animator = GetComponentInChildren<Animator>();
		animator.SetBool(hashIdle, true);
	}
	
	
	void Update()
	{
		float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
		/* 
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
		Quaternion turn = Quaternion.Euler(0f, rotation, 0f);
		rb.MoveRotation(rb.rotation * turn);
		*/
		animator.SetFloat(hashSpeed, translation);


		bool idle = !(translation != 0);
		animator.SetBool(hashIdle, idle);
	}
}
