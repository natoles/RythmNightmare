using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreamScript : MonoBehaviour
{
    public GameObject screamer;

    public int VISIBLE_TIME = 120;
    public int DB_NEEDED = 70;
        
    private int screamed_db = 0;
    private int count_till;
    private int random_count = 0;
    private int visible_count = 0;

    // Use this for initialization
    void Start()
    {
        count_till = Random.Range(180, 600);
    }

    // Update is called once per frame
    void Update()
    {
        if (screamer.activeSelf)
        {
            if (++visible_count == VISIBLE_TIME)
            {
                screamer.SetActive(false);
                visible_count = 0;
                random_count = 0;
                count_till = Random.Range(180, 600);
            }
            else
            {
                if ((screamed_db = 80) >= DB_NEEDED)
                {
                    this.GetComponent<GameScript>().score++;
                }
            }
            
        }
        else
        {
            if (++random_count == count_till)
            {
                screamer.SetActive(true);
            }
        }
    }
}
