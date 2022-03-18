using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class study : MonoBehaviour
{
    private const float AttackInterval = 3f;
    private float _atttackIntervalTimer;
    
    void Start()
    {
        InvokeRepeating("PrintText", 9f, 3f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void PrintText()
    {
        print("공격!!!");
    }
}
