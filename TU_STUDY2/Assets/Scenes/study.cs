using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class study : MonoBehaviour
{
    void Start()
    {
        Invoke("PrintText",3f);
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
