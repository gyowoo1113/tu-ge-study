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

            var swordDatas = itemDatas
                .Where(item => item.itemName.Contains("Sword"))
                .Select(item => new SwordData
                {
                    itemName = item.itemName,
                    itemLevel = item.itemLevel,
                    attackPower = 10 * item.itemLevel,
                });

            foreach(var swordData in swordDatas)
            {
                print($"{swordData.itemName}'s Power : {swordData.attackPower}");
            }
        }
    }
}
