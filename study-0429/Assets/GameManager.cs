using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public int coin;
    
    private void Awake() 
    {
        if (Instance != null){
            Debug.LogWarning("이미 있음...");
            }
        Instance = this;
    }
}
