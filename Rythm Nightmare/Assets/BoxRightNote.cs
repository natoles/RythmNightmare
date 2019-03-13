using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxRightNote : MonoBehaviour {

    public RightNote[] notes = new RightNote[10];
    public int numberNotes = 0;
    GameScript game;

	// Use this for initialization
	void Start () {
        game = GameObject.Find("Game").GetComponent<GameScript>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("right"))
        {
            if (numberNotes > 0) 
            {
                Destroy(notes[0].gameObject);
                Decaler(notes);
                game.score += 1;
                numberNotes--;
            } else {
                game.score -= 1;
            }
        }
    }

    void Decaler(RightNote[] arr)
    {
        for (int i = 0; i< arr.Length -1; i++)
        {
            arr[i] = arr[i + 1];
        }
    }
    
}
