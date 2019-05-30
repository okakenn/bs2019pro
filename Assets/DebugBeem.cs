using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugBeem : MonoBehaviour {

    public int lifeTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        lifeTime--;
        if (lifeTime < 0) Destroy(this.gameObject);
	}
}
