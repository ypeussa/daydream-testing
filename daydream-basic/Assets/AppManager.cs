using UnityEngine;

public class AppManager : MonoBehaviour {
    void Start() {
        Input.backButtonLeavesApp = true;
    }

    void Update() {
        // Exit when (X) is tapped.
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
    }
}
