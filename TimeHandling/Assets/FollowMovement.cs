using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMovement : MonoBehaviour {
    public Transform target;
    public Timing timing;
    public enum Timing { Update, FixedUpdate, LateUpdate };

    Vector3 relativePosition;

    void Start() {
        relativePosition = transform.position-target.position;
    }

    void Update() {
        if (timing == Timing.Update)
            transform.position = target.position + relativePosition;
    }

    void LateUpdate() {
        if (timing == Timing.LateUpdate)
            transform.position = target.position + relativePosition;
    }
    void FixedUpdate() {
        if (timing == Timing.FixedUpdate)
            transform.position = target.position + relativePosition;
    }
}
