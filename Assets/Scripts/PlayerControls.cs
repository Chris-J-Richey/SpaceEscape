using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

    public GameObject ShipLight;
    public GameObject FlareDrops;
    public GameObject Door1;
    public GameObject Door2;
    public static bool Door1Range;
    public static bool Door2Range;
    public GameObject Door3;
    public static bool Door3Range;
    public static int flarecount;
    public int flaremax;

    private Rigidbody rbP;

    void Start() {
        rbP = GetComponent<Rigidbody>();

        ShipLight.SetActive(false);
    }

    void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float movePitch = Input.GetAxis("Pitch");
        float moveturn = Input.GetAxis("turn");

        Vector3 turn = new Vector3(movePitch, moveturn, 0.0f);
        Vector3 move = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rbP.AddRelativeForce(move);
        rbP.transform.Rotate(turn);
        if (rbP.velocity.sqrMagnitude > 10) {
            rbP.velocity *= 0.99f;
            Debug.Log(rbP.velocity);
        }

        if (Input.GetKeyDown(KeyCode.U) && flarecount < flaremax) {
            flarecount++;
            Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Object flareObj = Instantiate(FlareDrops, spawnPosition, Quaternion.identity);
            GameObject flareGameObj = (GameObject)flareObj;
        }

        if (Input.GetKeyDown(KeyCode.E) && ShipLight.activeSelf) {
            ShipLight.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.E) && !ShipLight.activeSelf) {
            ShipLight.SetActive(true);
        }

        if (Door1Range) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                Door1.transform.position = new Vector3(Door1.transform.position.x, 30f, Door1.transform.position.z);
            }
        }
        else {
            Door1.transform.position = new Vector3(Door1.transform.position.x, 8.5f, Door1.transform.position.z);
        }

        if (Door2Range) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                Door2.transform.position = new Vector3(Door2.transform.position.x, 30f, Door2.transform.position.z);
            }
        }
        else {
            Door2.transform.position = new Vector3(Door2.transform.position.x, 8.5f, Door2.transform.position.z);
        }

        if (Door3Range) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                Door3.transform.position = new Vector3(Door3.transform.position.x, 30f, Door3.transform.position.z);
            }
        }
        else {
            Door3.transform.position = new Vector3(Door3.transform.position.x, 8.5f, Door3.transform.position.z);
        }
    }
}
