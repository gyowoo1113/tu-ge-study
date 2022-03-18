using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Monster : MonoBehaviour
{
    
    public abstract void Cry();

    // Start is called before the first frame update
    void Start()
    {
        Cry();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
