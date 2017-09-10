using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {

	public Transform door;
	public Transform openPoint;

	public float speed;

	Vector3 dir;
	float dist;
	Vector3 statePos;

	Collider player;

	void Start () {
		player = FindObjectOfType<PlayerMover>().GetComponentInChildren<Collider>();
		statePos = transform.position;
	}

	void Update () {
		if (dist > 0) {
			door.position += dir * speed * Time.deltaTime;
			dist -= speed * Time.deltaTime;
		} else {
			door.position = statePos;
		}
	}

	void OnTriggerEnter (Collider c) {
		if (c == player) {
			//door.position = openPoint.position;
			dir = (openPoint.position - door.position).normalized;
			dist = Vector3.Distance(openPoint.position, door.position);
			statePos = openPoint.position;
		}
	}

	void OnTriggerExit (Collider c) {
		if (c == player) {
			//door.position = transform.position;
			dir = (transform.position - door.position).normalized;
			dist = Vector3.Distance(transform.position, door.position);
			statePos = transform.position;
		}
	}
}
