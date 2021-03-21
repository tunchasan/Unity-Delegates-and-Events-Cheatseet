using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challange1 : MonoBehaviour
{
    // Create a delegate of type void that calculates the sum of two numbers. Use a lambda expression to avoid having a dedicated method.
    public Action<int, int> CalculateSum;

    private void Start()
    {
        CalculateSum = (number1, number2) => Debug.Log(number1 + number2);

        CalculateSum(3, 4);
        
        // OR
        
        CalculateSum?.Invoke(3, 4);
    }
}
