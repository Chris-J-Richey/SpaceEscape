using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript1 : MonoBehaviour {
    
    private void OnTriggerEnter(Collider other) {
        PlayerControls.Door1Range = true;
    }

    private void OnTriggerExit(Collider other) {
        PlayerControls.Door1Range = false;
    }
}
