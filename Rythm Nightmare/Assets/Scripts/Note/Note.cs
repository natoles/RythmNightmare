using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour {

    protected Vector2 velocity;
    protected Rigidbody2D rb;
    public float speed = 100f;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    protected void SetSpeed()
    {
        velocity = new Vector2(0, -1 * 15);
    }
}
