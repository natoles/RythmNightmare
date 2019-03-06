using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightNote : MonoBehaviour {

    Vector2 velocity;
    Rigidbody2D rb;
    public float speed = 5f;
    BoxRightNote box;

	// Use this for initialization
	void Start () {
        box = GameObject.Find("RightBox").GetComponent<BoxRightNote>();
        rb = GetComponent<Rigidbody2D>();
        velocity = new Vector2(0, -1 * speed);
        
        
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
	}
}
