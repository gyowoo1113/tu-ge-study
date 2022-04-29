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

            var itemLowerthan3 = 
                itemDatas
                    .Where(item => item.itemLevel < 3)
                    .Select(item => item.itemName);
            
            foreach(var itemName in itemLowerthan3)
                print(itemName);
        }
    }
}
