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
    // Start is called before the first frame update
    void Start()
    {
        rand = new System.Random();
        isActive = false;
        init = true;
    }

    // Update is called once per frame
    void Update()
    {
        oldNumberEntered = numberEntered;
        numberEntered = 5;//TODO
        
        if (init)
        {
            coroutine = Wait();
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
        }
        
        GUI.Label(new Rect(10, 100, 3000, 1000), display);
    }

}
