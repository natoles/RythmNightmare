using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreamScript : MonoBehaviour
{
    public GameObject screamer;
    public Arduino2 ard;

    public int VISIBLE_TIME = 200;
    public int DB_NEEDED = 70;
    System.Random rand;

    private int screamed_db = 0;
    private int count_till;
    private int random_count = 0;
    private int visible_count = 0;

    // Use this for initialization
    void Start()
    {
        rand = new System.Random();
        count_till = Random.Range(180, 600);
    }

    // Update is called once per frame
    void Update()
    {
        screamed_db = ard.distance;
        if (screamer.activeSelf)
        {
            if (++visible_count == VISIBLE_TIME)
            {
                screamer.SetActive(false);
                visible_count = 0;
                random_count = 0;
                count_till = Random.Range(600, 900);
            }
            else
            {
                if (screamed_db >= DB_NEEDED)
                {
                    this.GetComponent<GameScript>().score++;
                }
            }
            
        }
        else
        {
            if (++random_count == count_till)
            {
                screamer.transform.Rotate(1, 1, rand.Next(0,360)); 
                screamer.SetActive(true);
            }
        }
    }
}
