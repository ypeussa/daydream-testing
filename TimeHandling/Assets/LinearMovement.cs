using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LinearMovement : MonoBehaviour {

    public float speed = 1.0f;
    public Timing timing;
    public enum Timing { Update, FixedUpdate, LateUpdate};

	void Start () {
		
	}
	
	void Update () {
        if (timing == Timing.Update)
            transform.position += Time.deltaTime * speed * Vector3.forward;	
	}

    void LateUpdate() {
        if (timing == Timing.LateUpdate)
            transform.position += Time.deltaTime * speed * Vector3.forward;

    }
    void FixedUpdate() {
        if (timing == Timing.FixedUpdate)
            transform.position += Time.deltaTime * speed * Vector3.forward;
    }
}
