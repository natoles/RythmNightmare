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
    bool isActive;
    int timeInterval;
    private IEnumerator coroutine;
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


}
