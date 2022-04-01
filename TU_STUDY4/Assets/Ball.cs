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

        if(Input.GetKeyDown(KeyCode.Space))
        {
            direction += new Vector3(0,100f,0);
        }

        if(Input.GetMouseButtonDown(0))
        {
            var pos = Input.mousePosition;
            var cam = FindObjectOfType<Camera>();
            var ray = cam.ScreenPointToRay(pos);
            
            if(Physics.Raycast(ray,out var hitInfo))
            {
                print(hitInfo.collider.name);
            }
        }
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForce(direction);
    }
}
