using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxUpNote : BoxNote {

    public UpNote[] notes = new UpNote[10];
    public int numberNotes = 0;

    // Use this for initialization
    void Start()
    {
        game = GameObject.Find("Game").GetComponent<GameScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up"))
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
