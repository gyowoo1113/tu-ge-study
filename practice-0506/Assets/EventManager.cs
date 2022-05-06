using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
    private static EventManager _instance;

    private Dictionary<string, Action> _eventDb;
    
    private void Awake()
    {
        _eventDb = new Dictionary<string, Action>();
    }

    public static EventManager Instance
    {
        get
        {
            if (_instance == null) _instance = FindObjectOfType<EventManager>();
            if (_instance == null)
            {
                var go = new GameObject(nameof(EventManager));
                _instance = go.AddComponent<EventManager>();
            }
            return _instance;
        }
    }

    public void Subscribe(string eventName, Action action)
    {
        if (_eventDb.ContainsKey(eventName))
        {
            _eventDb.Add(eventName,action);
        }
        else
        {
            _eventDb[eventName] = action;
        }
    }

    public void Emit(string eventName)
    {
        if (_eventDb.ContainsKey(eventName))
        {
            _eventDb[eventName].Invoke();
        }
        else
        {
            Debug.LogError($"'{eventName}'이라는 이벤트는 없음");
        }
    }
}
