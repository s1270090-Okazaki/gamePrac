﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public bool clockwise = true;
    void Update()
    {
        if (clockwise)
        {
            transform.Rotate(new Vector3(0,0,-5));
        } else
        {
            transform.Rotate(new Vector3(0,0,5));
        }
    }
}
