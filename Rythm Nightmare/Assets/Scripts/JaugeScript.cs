using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JaugeScript : MonoBehaviour {

    private int MIN_COUNT = 30;
    private int MAX_COUNT = 180;
    private int MIN_SLEEP = 60;
    private int MAX_SLEEP = 180;

    public GameScript game;
    public GameObject player;
    public Rigidbody2D rb;
    private float edgeY = 3.15f;
    private Vector2 velocity;
    private int speed;
    private int sleep;
    private bool toUp;
    private bool sleeping;
    private int nextChange;
    private int nextSleep;
    private int countSleep;
    private int lengthSleep;
    private int count;

	// Use this for initialization
	void Start () {
        speed = 1;
        velocity = new Vector2(0, speed);
        toUp = true;
        sleeping = false;
        nextChange = Random.Range(MIN_COUNT, MAX_COUNT);
        nextSleep = Random.Range(MIN_COUNT, MAX_COUNT);
        count = 0;
        countSleep = 0;
        sleep = 0;
    }

    // Update is called once per frame
    void Update()
    {
        game.score += Mathf.Max(0, 2 - Mathf.Abs( (int) Mathf.Round((2*(transform.position.y - player.transform.position.y)))));
        if (sleeping && sleep < lengthSleep)
        {
            sleep++;
        }
        else
        {
            sleeping = false;
            if (countSleep++ == nextSleep)
            {
                countSleep = 0;
                sleep = 0;
                lengthSleep = Random.Range(MIN_SLEEP, MAX_SLEEP);
                sleeping = true;
            }
            else
            {
                if (toUp)
                {
                    if (count++ == nextChange)
                    {
                        velocity.y = -speed;
                        toUp = false;
                        nextChange = Random.Range(MIN_COUNT, MAX_COUNT);
                        count = 0;
                    }
                    else
                    if (transform.position.y >= edgeY - transform.localScale.y * 0.07f)
                    {
                        velocity.y = -speed;
                        toUp = false;
                    }
                }
                else
                {
                    if (count++ == nextChange)
                    {
                        velocity.y = speed;
                        toUp = true;
                        nextChange = Random.Range(MIN_COUNT, MAX_COUNT);
                        count = 0;
                    }
                    else
                    if (transform.position.y <= -edgeY + transform.localScale.y * 0.07f)
                    {
                        velocity.y = speed;
                        toUp = true;
                    }
                }
                rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
            }
        }
    }
}
