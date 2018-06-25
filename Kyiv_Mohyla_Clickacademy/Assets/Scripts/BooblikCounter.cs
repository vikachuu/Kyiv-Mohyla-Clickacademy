using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooblikCounter : MonoBehaviour {
	// Use this for initialization
	public int id = 1;
	void Start () {

	}
	// Update is called once per frame
	void Update () {
	}
	public void increaseId(){
		id++;
	}
	public void decreaseId(){
		id--;
	}
}
