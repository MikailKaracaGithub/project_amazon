﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlatforms : MonoBehaviour
{

    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position -= Vector3.up * speed * Time.deltaTime;
    }
}
