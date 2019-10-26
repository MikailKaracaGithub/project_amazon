﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == GameObject.FindGameObjectWithTag("Player"))
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
