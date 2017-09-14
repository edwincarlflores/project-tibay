using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChiBScriptSpawn : MonoBehaviour {
	public GameObject spawnPrefab;

	// Use this for initialization
	void Start () {
		MakeThingToSpawn();
		spawnPrefab.SetActive (false);
	}

	void MakeThingToSpawn()
	{
		// create a new gameObject
		GameObject clone = Instantiate (spawnPrefab, transform.position, transform.rotation) as GameObject;
	}
}
