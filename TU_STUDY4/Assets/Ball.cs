using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Vector3 direction;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();    
    }

    void Update()
    {
        var hor = Input.GetAxis("Horizontal");
        var ver = Input.GetAxis("Vertical");

        direction = new Vector3(hor,0,ver);
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForce(direction);
    }
}
