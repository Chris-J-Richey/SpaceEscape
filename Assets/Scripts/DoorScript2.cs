using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript2 : MonoBehaviour {
    
    private void OnTriggerEnter(Collider other) {
        PlayerControls.Door2Range = true;
    }

    private void OnTriggerExit(Collider other) {
        PlayerControls.Door2Range = false;
    }
}
