using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO.Ports;
using DigitalRuby.Threading;

public class Arduino2 : MonoBehaviour
{

    SerialPort stream = new SerialPort("\\\\.\\COM13", 9600);
    public int distance = 0;

    void Start()
    {
        stream.Open();
        EZThread.BeginThread(ReadDistance, false);
    }

    void Update()
    {
        //Debug.Log(distance);
    }
    /*
    private void OnGUI()
    {
        string newString = "Connected: " + distance;
        GUI.Label(new Rect(10, 10, 300, 100), newString);
    }*/

    public void ReadDistance()
    {
        Debug.Log("Thread called");
        string value = stream.ReadLine();
        distance = int.Parse(value);      
    }

}

