using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MsMetaController : MonoBehaviour {

    public float speed = 1;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if( Input.GetKey("d") || Input.GetKey("right") )
            transform.Translate(Vector3.right * speed);
        if( Input.GetKey("a") || Input.GetKey("left") )
            transform.Translate(Vector3.left * speed);
        //if( Input.GetKey("w") )
        //    transform.Translate(Vector3.up);
        //if( Input.GetKey("s") )
        //    transform.Translate(Vector3.down);
    }

    void moveRight() {
        transform.Translate(Vector3.right * speed);
    }
}
