using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncExample : MonoBehaviour
{
    // Return type delegate
    // public delegate int CharacterLength(string text);

    // Function Delegate, also knows as Return Type Delegate
    // Func<input, output> name
    private Func<string, int> _characterLength;

    private void Start()
    {
        _characterLength = GetCharacters;
        
        Debug.Log(_characterLength("Jonathan Dell"));
    }

    private int GetCharacters(string name)
    {
        return name.Length;
    }
}
