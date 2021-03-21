using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private void Start()
    {
        Teleport.OnTeleport += UpdatePosition;
    }

    private void UpdatePosition(Vector3 teleportPosition)
    {
        transform.position = teleportPosition;
    }

    private void OnDisable()
    {
        Teleport.OnTeleport -= UpdatePosition;
    }
}
