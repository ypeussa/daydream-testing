using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingDoor : MonoBehaviour {
    public Transform doorObject;
    public Transform openPosition;
    public float speed;

    // SerializeField makes a private variable visible & editable in Editor UI as if it was public
    [SerializeField]
    bool open;

    Vector3 closedPosition;

    public void Open() {
        open = true;
    }

    public void Close() {
        open = false;
    }

    void Awake() {
        closedPosition = doorObject.position;
    }

    void Update() {
        var destination = open ? openPosition.position : closedPosition;
        doorObject.position = Vector3.MoveTowards(doorObject.position, destination, Time.deltaTime * speed);
    }
}
