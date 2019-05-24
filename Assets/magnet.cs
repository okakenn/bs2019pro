using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnet : MonoBehaviour {

    public float rayDistance;
    public GameObject hitObject;

    public float moveSpeed;
    public float minDistance;
    public float maxDistance;
    public int PlayerMagnet;

    Ray targetRay;
    RaycastHit raycast;



	// Use this for initialization
	void Start () {

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

        if (Input.GetKeyDown(KeyCode.M))//自身のマグネットの＋(1),－(0)の切り替え
        {
            if(PlayerMagnet == 0)
            {
                PlayerMagnet = 1;
            }
            if(PlayerMagnet == 1)
            {
                PlayerMagnet = 0;
            }
        }


        if (PlayerMagnet == 1)
        {
            if(hitObject.tag == "plus")
            {
                if ((transform.position - hitObject.transform.position).sqrMagnitude > minDistance)
                {
                    Vector3 moveVec = (transform.position - hitObject.transform.position).normalized * moveSpeed;
                    hitObject.GetComponent<Rigidbody>().MovePosition(hitObject.transform.position + moveVec);
                }
            }
            if (hitObject.tag == "minus")
            {
                if ((transform.position - hitObject.transform.position).sqrMagnitude < maxDistance)
                {
                    Vector3 moveVec = (transform.position - hitObject.transform.position).normalized * moveSpeed;
                    hitObject.GetComponent<Rigidbody>().MovePosition(hitObject.transform.position - moveVec);
                }
            }
        }

        if (PlayerMagnet == 0)
        {
            if (hitObject.tag == "minus")
            {
                if ((transform.position - hitObject.transform.position).sqrMagnitude > minDistance)
                {
                    Vector3 moveVec = (transform.position - hitObject.transform.position).normalized * moveSpeed;
                    hitObject.GetComponent<Rigidbody>().MovePosition(hitObject.transform.position + moveVec);
                }
            }
            if (hitObject.tag == "plus")
            {
                if ((transform.position - hitObject.transform.position).sqrMagnitude < maxDistance)
                {
                    Vector3 moveVec = (transform.position - hitObject.transform.position).normalized * moveSpeed;
                    hitObject.GetComponent<Rigidbody>().MovePosition(hitObject.transform.position - moveVec);
                }
            }
        }


    }
}
