﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SetupLocalPlayer : NetworkBehaviour
{
    void Start()
    {
        if (isLocalPlayer)
        {
            gameObject.GetComponent<CarController>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<CarController>().enabled = false;
        }

    }

    public override void OnStartLocalPlayer()
    {
        Camera.main.GetComponent<CameraFollow>().setTarget(gameObject.transform);
    }
}