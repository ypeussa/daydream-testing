﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FramerateLimiter : MonoBehaviour {
    
    void Awake() {
        Application.targetFrameRate = 60;
    }
}
