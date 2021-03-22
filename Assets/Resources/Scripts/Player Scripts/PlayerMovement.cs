using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Rigidbody2D rb;
	public float movespeed = 5f;
	private Vector2 movement;
	public Animator animator;

	// Update is called once per frame
	void Update()
	{
		//Input
		movement.x =Input.GetAxisRaw("Horizontal");
		movement.y = Input.GetAxisRaw("Vertical");

		animator.SetFloat("horizontal", movement.x);
		animator.SetFloat("vertical", movement.y);
		animator.SetFloat("speed", movement.sqrMagnitude);
	}

	private void FixedUpdate()
	{
		rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);
	}
}
