using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMover : MonoBehaviour {

	public Transform comparison;

	void Update () {
		transform.Rotate(GvrControllerInput.Gyro);
		comparison.rotation = GvrControllerInput.Orientation;
	}
}
