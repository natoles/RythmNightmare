using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownNote : Note {

    BoxDownNote box;

    // Use this for initialization
    void Start()
    {
        SetSpeed();
        rb = GetComponent<Rigidbody2D>();
        box = GameObject.Find("DownBox").GetComponent<BoxDownNote>();
        box.notes[box.numberNotes] = this;
        box.numberNotes++;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }
}
