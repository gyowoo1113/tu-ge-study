using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventEmitter : MonoBehaviour
{
    public string eventName;
    public int param;

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            EventManager.Instance.Emit(eventName,param);
        }
    }
}
