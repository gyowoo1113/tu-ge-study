using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subscriber : MonoBehaviour
{
    public string eventName;

    void Start()
    {
        EventManager.Instance.Subscribe(eventName,OnEvent);
    }

    private void OnEvent()
    {
        print($"{gameObject.name} : {eventName} 발동");
    }
}
