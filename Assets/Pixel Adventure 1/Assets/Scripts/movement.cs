using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
	private Rigidbody2D rb;
	public CharacterController controller;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	public float jump;

	void Start()
    {
		rb = GetComponent<Rigidbody2D>();
    }
	// Update is called once per frame
	void Update()
	{

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		if (Input.GetButtonDown("Jump"))
		{
			rb.AddForce(new Vector2(rb.velocity.x, jump));
	
		}
	
	}
	void FixedUpdate()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime,false, false);
		
	}

}