using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxRightNote : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerStay2D(Collider2D col)
    {
       if (Input.GetKeyDown("right"))
        {
            Destroy(col.gameObject);
        }
        
        
    }
}
