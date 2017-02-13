using UnityEngine;

using System.Collections;



public class Player : MonoBehaviour {



	public float speed = 50f;

	public float jumpPower = 150f;

	public bool grounded;

	private Rigidbody2D rigidBody2D;



	void Start ()

	{

		rigidBody2D = gameObject.GetComponent<Rigidbody2D>();

	}



	void Update () 

	{



	}



	void FixedUpdate ()

	{

		float horizontal = Input.GetAxis ("Horizontal");

		rigidBody2D.AddForce ((Vector2.right * speed) * horizontal);



	}

}