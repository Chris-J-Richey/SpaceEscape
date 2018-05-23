using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour {

    public GameObject WinText;

    private void Start() {
        WinText.SetActive(false);
    }

    private void OnTriggerEnter(Collider other) {
        WinText.SetActive(true);
    }
}
