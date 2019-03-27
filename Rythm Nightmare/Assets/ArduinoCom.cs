using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ArduinoCom : MonoBehaviour {

    SerialPort sp = new SerialPort("\\\\.\\COM13", 9600);
    string s;

	// Use this for initialization
	void Start () {
        sp.Open();
        sp.ReadTimeout = 1;
    }
	
	// Update is called once per frame
	void Update () {
        
        if (sp.IsOpen)
        {
            try
            {
                Debug.Log("Ah");
                Debug.Log(sp.ReadLine());
                //s = sp.ReadExisting();
                Debug.Log(sp.ReadByte());
            }
            catch (System.Exception) { }
        }
        else Debug.Log("Nope");
	}
}
