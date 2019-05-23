using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {

    bool isJump = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)&& isJump == true)
        {
            transform.GetComponent<Rigidbody>().AddForce(0, 5, 0, ForceMode.Impulse);
            isJump = false;
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            isJump = true;
        }
    }
}
