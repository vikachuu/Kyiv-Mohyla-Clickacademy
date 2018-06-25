using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class PPCanimation: MonoBehaviour 
	{
		public int id = 1;
		public Rigidbody2D projectile;
		public Transform projectileSpawnPoint;
		public float projectileVelocity;
		// Use this for initialization
		void Start () {
		}

		// Update is called once per frame
		void Update () {
			if (Input.GetMouseButtonDown(0))
			{
				//Rigidbody2D bulletInstance = Instantiate(projectile, projectileSpawnPoint.position, Quaternion.Euler(new Vector3(0, 0, transform.localEulerAngles.z))) as Rigidbody2D;
				//bulletInstance.GetComponent<Rigidbody2D>().AddForce(projectileSpawnPoint.up * projectileVelocity);
				//id++;
			}
		}

		public void OnClicked() {
			Rigidbody2D bulletInstance = Instantiate(projectile, projectileSpawnPoint.position, Quaternion.Euler(new Vector3(0, 0, transform.localEulerAngles.z))) as Rigidbody2D;
			bulletInstance.GetComponent<Rigidbody2D>().AddForce(projectileSpawnPoint.up * projectileVelocity);
			id++;
		}
	}




