using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Calculus : MonoBehaviour
{
    int solution;
    int score;
    int numberEntered = 0;
    int oldNumberEntered = 0;
    int leftNumber;
    int rightNumber;
    int operand;
    System.Random rand;
    bool init;
    int tmp;
    bool isActive;
    int timeInterval;
    private IEnumerator coroutine;
    string display;
    int xpos = 10;
    int ypos = 10;
    private GUIStyle guiStyle = new GUIStyle(); //create a new variable
    // Start is called before the first frame update
    void Start()
    {
        rand = new System.Random();
        isActive = false;
        init = true;
        guiStyle.fontSize = 80; //change the font size
        guiStyle.normal.textColor = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        oldNumberEntered = numberEntered;
        numberEntered = 5;//TODO
        
        if (init)
        {
            coroutine = Wait();
            xpos = rand.Next(10, 1000);
            ypos = rand.Next(10, 1000);
            oldNumberEntered = numberEntered;
            init = false;
            isActive = true;
            leftNumber = rand.Next(100, 999);
            rightNumber = rand.Next(100, 999);
            operand = rand.Next(0, 1);

            if (operand == 0)
            {
                solution = leftNumber + rightNumber;
            }
            else
            {
                if (leftNumber < rightNumber)
                {
                    tmp = leftNumber;
                    leftNumber = rightNumber;
                    rightNumber = tmp;
                }
                solution = leftNumber - rightNumber;
            }
        }

        if (isActive)
        {
            if (numberEntered == solution)
            {
                isActive = false;
                score += 20;
            }
            else if (numberEntered != oldNumberEntered)
            {
                score -= 10;
            }
        }
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(10);
        if (isActive)
        {
            score -= 30;
        }
        isActive = false;
        timeInterval = rand.Next(10, 20);
        yield return new WaitForSeconds(timeInterval);
        init = true;
    }

    private void OnGUI()
    {
        if (isActive)
        {
            if (operand == 0)
            {
                display = leftNumber + " + " + rightNumber;
            }
            else
            {
                display = leftNumber + " - " + rightNumber;
            } 
        } else
        {
            display = "  ";
        }

        GUI.Label(new Rect(xpos, ypos, 300, 100), display, guiStyle);
    }

}
