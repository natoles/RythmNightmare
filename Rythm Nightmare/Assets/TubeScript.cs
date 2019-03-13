using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeScript : MonoBehaviour {

    public GameObject player;
    public Rigidbody2D rb;
    private float edgeX = 10.9f;
    private Vector2 velocity;
    private int randSpeed;
    private bool toRight;
    private int nextChange;
    private int count;

	// Use this for initialization
	void Start () {
        randSpeed = Random.Range(10, 50);
        velocity = new Vector2(randSpeed, 0);
        toRight = true;
        nextChange = Random.Range(30, 300);
        count = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (toRight)
        {
            if (count++ == nextChange)
            {
                randSpeed = Random.Range(10, 50);
                velocity.x = -randSpeed;
                toRight = false;
                nextChange = Random.Range(20, 100);
                count = 0;
            }
            else
            if (transform.position.x >= edgeX - transform.localScale.x * 0.07f)
            {
                randSpeed = Random.Range(10, 50);
                velocity.x = -randSpeed;
                toRight = false;
            }
        }
        else
        {
            if (count++ == nextChange)
            {
                randSpeed = Random.Range(10, 50);
                velocity.x = randSpeed;
                toRight = true;
                nextChange = Random.Range(20, 100);
                count = 0;
            }
            else
            if (transform.position.x <= -edgeX + transform.localScale.x * 0.07f)
            {
                randSpeed = Random.Range(10, 50);
                velocity.x = randSpeed;
                toRight = true;
            }
        }
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
	}
}
