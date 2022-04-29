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

            var sword1 = itemDatas.FirstOrDefault(item => item.itemName = "Sword1");
            if (sword1 != null)
                print($"{sword1.itemName}: Lv.{sword1.itemLevel}");
            //else
                //print($"{sword1.itemName}: Lv.{sword1.itemLevel}");
        }
    }
}
