using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge : MonoBehaviour
{
    public delegate void Teleport(Vector3 position);
    
    public static event Teleport OnTeleport;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            OnTeleport?.Invoke(new Vector3(-2, 5, 0));
    }
}
