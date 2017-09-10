using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GvrInputTesting : MonoBehaviour {
	Text text;

	void Start () {
		text = GetComponent<Text>();
	}
	
	void Update () {
		text.text = "" + GvrControllerInput.Accel + "\n" + GvrControllerInput.Gyro;
	}
}
