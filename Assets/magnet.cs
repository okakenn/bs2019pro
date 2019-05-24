using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnet : MonoBehaviour {

    public float rayDistance;
    public GameObject hitObject;

    public float moveSpeed;
    public float minDistance;
    public float maxDistance;

    Ray targetRay;
    RaycastHit raycast;

    bool targetHere = false;
    Vector3 Distance;
    int targetTime;

    Rigidbody rigid;

	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        targetRay.direction = transform.forward.normalized;
        targetRay.origin = transform.position;

        Debug.DrawRay(transform.position, targetRay.direction * rayDistance, Color.yellow, 0.1f, false);

        if (Physics.Raycast(targetRay, out raycast, rayDistance))
        {
            hitObject = raycast.collider.gameObject;
        }
        ////ここまでがレーザーが当たっているオブジェクトのデータの取得

        if (Input.GetKeyDown(KeyCode.M))
        {

        }
        if (Input.GetKeyDown(KeyCode.Return)&& hitObject.tag=="plus")//
        {
            targetHere = true;
            Distance = hitObject.transform.position - this.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.Return) && hitObject.tag == "minus")//
        {
            targetHere = true;
            Distance = hitObject.transform.position - this.transform.position;
        }


        if (targetHere == true&& hitObject.tag == "plus")
        {
            if ((transform.position - hitObject.transform.position).sqrMagnitude > minDistance)
            {
                Vector3 moveVec = (transform.position - hitObject.transform.position).normalized * moveSpeed;
                hitObject.GetComponent<Rigidbody>().MovePosition(hitObject.transform.position + moveVec);
            }
        }

        if (targetHere == true && hitObject.tag == "minus")
        {
            if ((transform.position - hitObject.transform.position).sqrMagnitude < maxDistance)
            {
                Vector3 moveVec = (transform.position - hitObject.transform.position).normalized * moveSpeed;
                hitObject.GetComponent<Rigidbody>().MovePosition(hitObject.transform.position - moveVec);
            }
        }
    }
}
