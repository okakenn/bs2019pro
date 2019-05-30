using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour {

    //キー入力のための変数１
    private Input_All INPUT_All;
    public GameObject GAME_CONTROL;
    bool G_FRONT,G_LEFT,G_BACK,G_RIGHT;
    bool D_JUMP;
    ///////////////////////////

    ///速度の変数
    public float SPEED = 5.0f;
    public float PTURN_SPEED = 0.5f;
    ///

    ///移動関係
    Vector3 HOUKOU;
    ///

    ///
    public GameObject MAIN_CAMERA;
    Camera_move C_MOVE;
    ///

	// Use this for initialization
	void Start () {

        //キー入力のための変数２
        G_FRONT = GAME_CONTROL.GetComponent<Input_All>().GO_FRONT;
        G_LEFT = GAME_CONTROL.GetComponent<Input_All>().GO_LEFT;
        G_BACK = GAME_CONTROL.GetComponent<Input_All>().GO_BACK;
        G_RIGHT = GAME_CONTROL.GetComponent<Input_All>().GO_RIGHT;
        D_JUMP = GAME_CONTROL.GetComponent<Input_All>().DO_JUMP;
        ///////////////////////////////////

    }
	
	// Update is called once per frame
	void Update () {

        //キー入力のための変数２
        G_FRONT = GAME_CONTROL.GetComponent<Input_All>().GO_FRONT;
        G_LEFT = GAME_CONTROL.GetComponent<Input_All>().GO_LEFT;
        G_BACK = GAME_CONTROL.GetComponent<Input_All>().GO_BACK;
        G_RIGHT = GAME_CONTROL.GetComponent<Input_All>().GO_RIGHT;
        D_JUMP = GAME_CONTROL.GetComponent<Input_All>().DO_JUMP;
        ///////////////////////////////////

        ///
        C_MOVE = MAIN_CAMERA.GetComponent<Camera_move>();

        HOUKOU = Vector3.zero;
        if (G_FRONT)
        {
            HOUKOU.z += 1.0f;
        }
        Debug.Log(G_FRONT);

        if (G_RIGHT)
        {
            HOUKOU.x += 1.0f;
        }
        if (G_BACK)
        {
            HOUKOU.z -= 1.0f;
        }
        if (G_LEFT)
        {
            HOUKOU.x -= 1.0f;
        }

        HOUKOU = HOUKOU.normalized * SPEED * Time.deltaTime;

        if (HOUKOU.magnitude > 0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(C_MOVE.ROTATION_H*HOUKOU), PTURN_SPEED);

            transform.position += C_MOVE.ROTATION_H * HOUKOU;

        }

        //Rigidbody PLAYER_RB = this.GetComponent<Rigidbody>();
        //Vector3 FRONT = new Vector3(0f, 0f, 0f);



	}
}
