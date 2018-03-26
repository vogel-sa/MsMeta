using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelArea : MonoBehaviour {
    private float width = 0;

    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update() {

    }

    public float getWidth() {
        if( width == 0 )
            width = GetComponent<SpriteRenderer>().sprite.bounds.size.x * transform.lossyScale.x;
        return width;
    }

    public float rightExtent() {
        return transform.position.x + ( width / 2.0f );
    }

    public float leftExtent() {
        return transform.position.x - ( width / 2.0f );
    }
}
