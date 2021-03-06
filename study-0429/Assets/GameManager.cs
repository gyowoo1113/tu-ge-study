using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private static GameManager _instance;
    
    public static GameManager Instance
    {
        get
        {
            if (_instance == null){
                _instance = FindObjectOfType<GameManager>();
            }
            if (_instance == null){
                var go = new GameObject(nameof(GameManager));
                _instance = go.AddComponent<GameManager>();
            }
            
            return _instance;
        }
    }
    
    public int coin;
    public ItemDataBase itemDatabase;
}
