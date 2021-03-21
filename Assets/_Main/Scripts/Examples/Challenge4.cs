using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge4 : MonoBehaviour
{
    // Create a delegate of type int that takes 2 numbers as a parameter and return sum.
    
    public static Func<int, int, int> Sum;

    private void Start()
    {
        Sum = (n1, n2) => n1 + n2;
        
        Debug.Log(Sum(3, 4));
        
        // OR
        
        Debug.Log(Sum?.Invoke(3, 5));
    }
}
