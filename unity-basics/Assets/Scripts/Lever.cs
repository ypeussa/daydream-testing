using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour {
    Transform target;

    public void Track(Transform t) {
        target = t;
    }

    void Update() {
        if (!target) return;
        // This lever is constrained to rotate only around the local y axis (on the local xz-plane). 
        // Find a point pLocal on the local xz-plane that is as close as possible to the target.
        // Hint: start by bringing the target's position into local coordinates. 

        Vector3 pLocal = transform.InverseTransformPoint(target.position);
        pLocal.y = 0;
        var pWorld = transform.TransformPoint(pLocal);
        // Rotate the lever towards pWorld.
        transform.LookAt(pWorld, transform.up);
    }
}
