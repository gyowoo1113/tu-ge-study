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

            var itemDatasOrderdByLevel = 
                itemDatas.OrderBy(item => item.itemLevel);
            
            foreach(var itemData in itemDatasOrderdByLevel)
            {
                print(itemData.itemName);
            }
        }
    }
}
