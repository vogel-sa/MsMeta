using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetaCameraController : MonoBehaviour {

    Transform player;
    Vector3 position;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        position.Set(player.transform.position.x, transform.position.y, transform.position.z);
        transform.position = position;
        //Debug.Log(transform.position);
        //Debug.Log(player.position);
	}
}
