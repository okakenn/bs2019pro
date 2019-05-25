using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{

    public Transform playertrans;
    public Transform cameratrans;

    // Use this for initialization
    void Start()
    {

        playertrans = transform.parent;
        cameratrans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");
        playertrans.transform.Rotate(0, -X_Rotation, 0);
        cameratrans.transform.Rotate(Y_Rotation, 0, 0);
    }
}