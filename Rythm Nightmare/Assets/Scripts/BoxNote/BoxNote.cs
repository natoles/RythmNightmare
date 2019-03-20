using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxNote : MonoBehaviour {

    protected float distanceGood = 0.5f;
    protected float distanceBad = 1.2f;
    protected int variationScore = 1;
    protected GameScript game;
    public int numberNotes = 0;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    
    protected void Decaler(Note[] arr, int numberNotes)
    {
        for (int i = 0; i < numberNotes ; i++)
        {
            arr[i] = arr[i + 1];
        }
    }

    protected void ProcessNoteScore(Note[] notes)
    {
        if (numberNotes > 0)
        {
            numberNotes--;
            float distanceTmp = Mathf.Abs(notes[0].gameObject.transform.position.y - this.transform.position.y);
            if (distanceTmp < distanceGood)
            {
                game.score += variationScore * 3;
            }
            else if (distanceTmp < distanceBad)
            {
                game.score += variationScore;
            }
            else
            {
                game.score -= variationScore;
            }
            
            Destroy(notes[0].gameObject);
            Decaler(notes, numberNotes+1);
        }
        else
        {
            game.score -= variationScore;
        }
        
    }

    virtual protected void MissNote(Note[] notes, float boxPos)
    {
        if (numberNotes > 0)
        {
            float distanceTmp = notes[0].gameObject.transform.position.y - this.transform.position.y;
            if (distanceTmp < -distanceBad)
            {
                game.score -= variationScore * 2;
                Destroy(notes[0].gameObject);
                Decaler(notes,numberNotes);
                numberNotes--;
            }
        }
    }
}
