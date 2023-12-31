﻿using UnityEngine;

namespace Utils {
    public class FPSTarget : MonoBehaviour {
        [SerializeField]
        int target = 30;

        void Awake() {
            QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = target;
        }

        void Update() {
            if (Application.targetFrameRate != target)
                Application.targetFrameRate = target;
        }
    }
}