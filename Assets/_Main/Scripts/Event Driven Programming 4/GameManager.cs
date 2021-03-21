using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private void ResetPlayer()
    {
        Debug.Log("Resetting Player");
    }

    private void OnEnable()
    {
        Player.OnDeath += ResetPlayer;
    }

    private void OnDisable()
    {
        Player.OnDeath -= ResetPlayer;
    }
}
