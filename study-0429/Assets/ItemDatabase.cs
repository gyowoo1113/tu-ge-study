using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[CreateAssetMenu(order = 0,fileName ="Item Database",menuName ="Study/Item/Create Item DB")]
public class ItemDataBase : ScriptableObject
{
    public ItemData[] itemDatas;
}

[Serializable]
public class ItemData
{
    public string itemName;
    public Sprite itemThumnail;
    public int itemLevel;
    public float itemDefaultDur;
}

[Serializable]
public class SwordData
{
    public string itemName;
    public int itemLevel;
    public float attackPower;
}

