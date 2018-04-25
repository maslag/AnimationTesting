using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {
	[SerializeField] private Weapon sword;

	private readonly string aimAxis = "Aim";
	private readonly string attackAxis = "Attack";
	private readonly int hashAttacking = Animator.StringToHash("attacking");

	void Update()
	{
		if(Input.GetButtonDown(attackAxis))
		{
			sword.OnSwing();
		}
	}
}
