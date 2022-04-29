using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            GameManager.Instance.coin++;
            var itemDatas = GameManager.Instance.itemDatabase.itemDatas;

            var itemNames = itemDatas
            .Select(item => item.itemName)
            .Aggregate((before,after) => 
            {
                return before.itemName + "," + after.itemName;
            });
            print(itemNames);
        }
    }
}
