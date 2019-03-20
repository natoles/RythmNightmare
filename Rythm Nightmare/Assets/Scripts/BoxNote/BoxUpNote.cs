using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxUpNote : BoxNote {

    public Note[] notes = new Note[10];

    // Use this for initialization
    void Start()
    {
        game = GameObject.Find("Game").GetComponent<GameScript>();
    }

    // Update is called once per frame
    void Update()
    {
        MissNote(notes, this.transform.position.y);

        if (Input.GetKeyDown("up"))
        {
            ProcessNoteScore(notes);
        }
    }
}
