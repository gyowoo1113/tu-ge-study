using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class study : MonoBehaviour
{
    void Start()
    {
        print("게임이 시작되었습니다.");
    }

    // Update is called once per frame
    void Update()
    {
        _atttackIntervalTimer += Time.deltaTime;
        if (_atttackIntervalTimer > 3f)
        {
            PrintText();
            _atttackIntervalTimer = 0f;
        }
    }

    void PrintText()
    {
        print("공격!!!");
    }
}
