using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public delegate void Death();

    public static event Death OnDeath;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            OnDeath?.Invoke();
    }
}
