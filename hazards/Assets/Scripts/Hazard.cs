﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("something entered the hazard");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
