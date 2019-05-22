using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour {

    public int score;

	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(score);
    }

	private void OnGUI()
    {
        string newString = "Score : " + score;
        GUI.Label(new Rect(10, 10, 300, 100), newString);
    }
}
