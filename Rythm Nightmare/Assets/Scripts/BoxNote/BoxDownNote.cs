using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDownNote : BoxNote {

    public Note[] notes = new Note[10];
    public int numberNotes = 0;

    // Use this for initialization
    void Start()
    {
        game = GameObject.Find("Game").GetComponent<GameScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("down"))
        {
            if (numberNotes > 0)
            {
                ProcessNoteScore(notes);
                Destroy(notes[0].gameObject);
                Decaler(notes);
                numberNotes--;
            }
            else
            {
                game.score -= variationScore;
            }
        }
    }
}
