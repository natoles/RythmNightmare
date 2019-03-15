using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNote : MonoBehaviour {
    
    enum Note {Left, Down, Up, Right};

    public GameObject LeftNote;
    public GameObject DownNote;
    public GameObject UpNote;
    public GameObject RightNote;

    public int difficulty = 1;

    private float[] noteX = new float[4] { -6f, -2f, 2f, 6f };
    private float noteY = 6.5f;

    private int compteur = 0;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (compteur++ % (60/difficulty) == 0)
        {
            int randNote = Random.Range(0, 4);
            switch(randNote)
            {
                case 0 :
                    Instantiate(LeftNote, new Vector3(noteX[0], noteY, 0), Quaternion.identity);
                    break;
                case 1:
                    Instantiate(DownNote, new Vector3(noteX[1], noteY, 0), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(UpNote, new Vector3(noteX[2], noteY, 0), Quaternion.identity);
                    break;
                default:
                    Instantiate(RightNote, new Vector3(noteX[3], noteY, 0), Quaternion.identity);
                    break;
            }
        }
	}
}
