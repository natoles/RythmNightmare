using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightNote : Note {

    BoxRightNote box;

	// Use this for initialization
	void Start () {
        SetSpeed();
        rb = GetComponent<Rigidbody2D>();
        box = GameObject.Find("RightBox").GetComponent<BoxRightNote>();
        box.notes[box.numberNotes] = this;
        box.numberNotes++;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }
}
