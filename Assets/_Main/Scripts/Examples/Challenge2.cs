using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge2 : MonoBehaviour
{
    // Create a delegate of type void that has no parameters and debug the gameObjects name.
    public Action OnGetName;

    private void Start()
    {
        OnGetName = () => Debug.Log("Name: " + gameObject.name);

        OnGetName();
        
        // OR
        
        OnGetName?.Invoke();
    }
}
