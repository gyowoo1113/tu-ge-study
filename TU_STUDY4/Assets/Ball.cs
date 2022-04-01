using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody _rigidbody;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();    
    }

    void Update()
    {
        var hor = Input.GetAxis("Horizontal");
        print($"horizontaol: {hor}");

        var direction = new Vector3();
        _rigidbody.AddForce(direction);
    }
}
