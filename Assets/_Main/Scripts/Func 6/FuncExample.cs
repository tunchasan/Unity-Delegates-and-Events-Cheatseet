using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncExample : MonoBehaviour
{
    // Return type delegate usage
    // public delegate int CharacterLength(string text);

    // Function Delegate, also knows as Return Type Delegate
    // Func<input, output> name
    private Func<string, int> _characterLength;

    private void Start()
    {
        // _characterLength = GetCharacters;
        
        // Lambda Usage
        _characterLength = (text) => text.Length;

        Debug.Log(_characterLength("Jonathan Dell"));
    }

    private int GetCharacters(string text)
    {
        return text.Length;
    }
}
