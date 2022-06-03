using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    void Start()
    {

#if UNITY_EDITOR
    transform.localScale = Vector3.one;
#else
    transform.localScale = Vector3.one * 10f;
#endif

    }

    void Update()
    {
#if TEST
        Debug.og("Hello world");
#endif

    }
}
