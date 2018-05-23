using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript3 : MonoBehaviour {
    
    private void OnTriggerEnter(Collider other) {
        PlayerControls.Door3Range = true;
    }

    private void OnTriggerExit(Collider other) {
        PlayerControls.Door3Range = false;
    }
}
