using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    private int _health = 10;

    public static Action<int> OnDamage;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            Damage();
    }

    private void Damage()
    {
        _health--;
        
        OnDamage?.Invoke(_health);
    }
}
