using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleController : MonoBehaviour {	
    void Update () {
        transform.rotation = GvrControllerInput.Orientation;
        if (GvrControllerInput.HomeButtonDown) {
            print("foo");
        }
	}
}
