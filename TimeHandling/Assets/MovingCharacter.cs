using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCharacter : MonoBehaviour {
    public float speed = 5.0f;
    public Transform camera;

    Vector3 toCamera;

    private void Start() {
        toCamera = camera.position - transform.position; 
    }
    void Update () {
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        camera.transform.position = transform.position + toCamera;
    }
}
