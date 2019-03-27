using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJauge : MonoBehaviour
{
    int distance;
    public Arduino2 ard;

    // Start is called before the first frame update
    void Start()
    {
        distance = 8;
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = ard.distance%16;
        transform.position = new Vector3(transform.position.x, -3.15f + distance * 0.4f, 0);
        if (Input.GetKeyDown(KeyCode.UpArrow))
            distance += 1;
        if (Input.GetKeyDown(KeyCode.DownArrow))
            distance -= 1;
    }
}
