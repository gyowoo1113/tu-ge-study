using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewBall : MonoBehaviour
{
    public void OnMove(InputValue value)
    {
        print(value.Get<Vector2>());
    }
}
