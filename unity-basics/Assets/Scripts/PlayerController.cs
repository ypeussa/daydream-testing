using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public LayerMask mask;
	PlayerMover mover;

	void Start () {
		mover = GetComponent<PlayerMover>();
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.Mouse0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit, Mathf.Infinity, mask)) {

				mover.MoveToPoint(hit.point);
			}
		}
	}
}
