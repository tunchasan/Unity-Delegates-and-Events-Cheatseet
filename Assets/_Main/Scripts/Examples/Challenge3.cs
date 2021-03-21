using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge3 : MonoBehaviour
{
    // Create a delegate of type int that returns the lenght of the gameObjects name.
    
    public Func<int> OnGetNameLenght;

    private void Start()
    {
        OnGetNameLenght = () => gameObject.name.Length;
        
        Debug.Log(OnGetNameLenght());
    }
}
