using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigzagMotionOrFollow : MonoBehaviour {
    public float width;
    public float period;
    Vector3 originalPos;

    public Transform followTarget;
    public Timing followTiming;
    public enum Timing { Update, FixedUpdate, LateUpdate };

    Vector3 relativePosition;

    void Start() {
        originalPos = transform.position;
        if (followTarget)
            relativePosition = transform.position - followTarget.position;
    }
    
    void LateUpdate() {
        if (followTarget && followTiming == Timing.LateUpdate)
            transform.position = followTarget.position + relativePosition;
    }
    void FixedUpdate() {
        if (followTarget && followTiming == Timing.FixedUpdate)
            transform.position = followTarget.position + relativePosition;
    }

    void Update () {
        if (followTarget && followTiming == Timing.Update) {
            transform.position = followTarget.position + relativePosition;
            return;
        }
        if (!followTarget) {
            // https://en.wikipedia.org/wiki/Triangle_wave
            transform.position = originalPos +
                Vector3.forward * (2 * width / Mathf.PI) * Mathf.Asin(Mathf.Sin(2 * (Mathf.PI / period) * Time.time));

        }
    }
}
