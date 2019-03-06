using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRightNote : MonoBehaviour {

    public GameObject RightGameObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerStay2D(Collider2D col)
    {     
        if (col.gameObject == RightGameObject)
        {
            if (Input.GetKeyDown("right"))
            {
                
                Destroy(col.gameObject);
            }
        }
        
    }
}
