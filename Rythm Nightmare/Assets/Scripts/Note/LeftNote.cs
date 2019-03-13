using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftNote : Note {

    BoxLeftNote box;

    // Use this for initialization
    void Start()
    {
        SetSpeed();
        rb = GetComponent<Rigidbody2D>();
        box = GameObject.Find("LeftBox").GetComponent<BoxLeftNote>();
        box.notes[box.numberNotes] = this;
        box.numberNotes++;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }
}
