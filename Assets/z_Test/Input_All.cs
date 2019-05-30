using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_All : MonoBehaviour {

    public bool GO_FRONT, GO_BACK, GO_RIGHT, GO_LEFT;
    public bool DO_JUMP;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //1.1前後左右の移動、ジャンプの入力
        //
        //
        //

        //1.1前後左右の移動、ジャンプ
        if (Input.GetKey(KeyCode.W))
        {
            GO_FRONT = true;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            GO_FRONT = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            GO_LEFT = true;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            GO_LEFT = false;
        }

        if (Input.GetKey(KeyCode.S))
        {
            GO_BACK = true;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            GO_BACK = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            GO_RIGHT = true;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            GO_RIGHT = false;
        }

        if (Input.GetKey(KeyCode.J))
        {
            DO_JUMP = true;
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            DO_JUMP = false;
        }


        //GO_FRONT = false;
        //GO_BACK = false;
        //GO_RIGHT = false;
        //GO_LEFT = false;
        //DO_JUMP = false;


    }
}
