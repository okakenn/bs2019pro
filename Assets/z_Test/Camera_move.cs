using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_move : MonoBehaviour {

    public GameObject PLAYER;
    public Quaternion ROTATION_V;
    public Quaternion ROTATION_H;

    public float TURN_SPEED = 10.0f;

    public float CAMERA_HEIGHT = 2.0f;

    // Use this for initialization
    void Start () {
        ROTATION_V = Quaternion.Euler(0, 0, 0);
        ROTATION_H = Quaternion.Euler(0, 0, 0);
        transform.rotation = ROTATION_H * ROTATION_V;
        transform.position = PLAYER.transform.position - transform.rotation * Vector3.down * CAMERA_HEIGHT;
    }

	
	// Update is called once per frame
	void Update () {


        if (Input.GetMouseButton(0))
        {
            ROTATION_H *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * TURN_SPEED, 0);
            ROTATION_V *= Quaternion.Euler(-Input.GetAxis("Mouse Y") * TURN_SPEED, 0, 0);
        }

        transform.rotation = ROTATION_H * ROTATION_V;

        transform.position = PLAYER.transform.position - transform.rotation * Vector3.down * CAMERA_HEIGHT;

    }
}
