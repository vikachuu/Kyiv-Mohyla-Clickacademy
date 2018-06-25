using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBooblik : MonoBehaviour {
	// Use this for initialization
	public BooblikCounter boobliks;
	private int ID;
	void Start () {
		ID = boobliks.id;
		boobliks.increaseId ();
	}
	void DestroyObjectDelayed()
	{
		// Kills the game object in 5 seconds after loading the object
		Destroy(gameObject, 2);
	}
	// Update is called once per frame
	void Update () {
		if (ID > 1) {
			DestroyObjectDelayed ();
		}
	}
}
