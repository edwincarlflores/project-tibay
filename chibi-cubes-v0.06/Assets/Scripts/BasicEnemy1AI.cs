using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy1AI : MonoBehaviour {
	public Transform goal;
	public Transform target;
	public float goalDistance;
	public float rotateSpeed;
	public float followspeed;
	public int MinDistance;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//rotate around
		if(Vector3.Distance(transform.position, target.position) > MinDistance){
		transform.position = goal.position + (transform.position - goal.position).normalized * goalDistance;
		transform.RotateAround(goal.position, Vector3.up, rotateSpeed);
		}

		//follow around
		else if(Vector3.Distance(transform.position, target.position) <= MinDistance){
		transform.position = Vector3.MoveTowards(transform.position, target.transform.position, followspeed);
		}

	}

	void OnCollisionEnter(Collision c)
	{
		// force is how forcefully we will push the player away from the enemy.
		float force = 300;

		// If the object we hit is the enemy
		if (c.gameObject.tag == "Player") {
			// Calculate Angle Between the collision point and the player
			Vector3 dir = c.contacts [0].point - transform.position;
			// We then get the opposite (-Vector3) and normalize it
			dir = -dir.normalized;
			// And finally we add force in the direction of dir and multiply it by force. 
			// This will push back the player
			GetComponent<Rigidbody> ().AddForce (dir * force);
		}
	}
}
