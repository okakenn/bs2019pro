using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnet : MonoBehaviour {

    public float rayDistance;
    public GameObject hitObject;

    Ray targetRay;
    RaycastHit raycast;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        targetRay.direction = transform.forward;
        Debug.DrawRay(transform.position, targetRay.direction * rayDistance, Color.yellow, 0.1f, true);

        if (Physics.Raycast(targetRay, out raycast, rayDistance))
        {
            hitObject = raycast.collider.gameObject;
            Debug.Log("Hit");
        }
	}
}
