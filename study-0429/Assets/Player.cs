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
                    from item in itemDatas
                    where item.itemLevel < 3
                    select item.itemName;
            
            foreach(var itemName in itemLowerthan3)
                print(itemName);
        }
    }
}
