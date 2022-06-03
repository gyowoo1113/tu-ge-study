using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class AI : MonoBehaviour
{
    public Transform traget;
    
    private Seeker _seeker; 
    private IAstarAI _ai;

    void Start()
    {
        _seeker = GetComponent<Seeker>();
        _ai = GetComponent<IAstarAI>();
    }

    // Update is called once per frame
    void Update()
    {
        _ai.destination = traget.position;
    }
}
