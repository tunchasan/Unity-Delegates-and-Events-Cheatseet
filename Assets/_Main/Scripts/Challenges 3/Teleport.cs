using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public delegate void Spawn(Vector3 position);
    
    public static event Spawn OnTeleport;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            OnTeleport?.Invoke(new Vector3(-2, 5, 0));
    }
}
