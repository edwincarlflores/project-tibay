using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed;

	private Rigidbody rb;
	public GameObject Player1;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		rb.freezeRotation = true;
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);


	}

	void OnCollisionEnter(Collision c)
	{
		// force is how forcefully we will push the player away from the enemy.
		float force = 300;

		// If the object we hit is the enemy
		if (c.gameObject.tag == "Enemy") {
			// Calculate Angle Between the collision point and the player
			Vector3 dir = c.contacts [0].point - transform.position;
			// We then get the opposite (-Vector3) and normalize it
			dir = -dir.normalized;
			// And finally we add force in the direction of dir and multiply it by force. 
			// This will push back the player
			GetComponent<Rigidbody> ().AddForce (dir * force);
		}

		if(c.gameObject.name == "Dead"){
			Player1.SetActive (false);
		}
		if (c.gameObject.tag == "Spikes") {
			Player1.SetActive (false);
		}
	}
		
}
