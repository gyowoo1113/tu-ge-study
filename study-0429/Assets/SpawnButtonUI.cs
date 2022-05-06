using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnButtonUI : MonoBehaviour
{
    public ObjectPoolManager poolingManager;
    public void Spawn(string objectName)
    {
        var position = new Vector3(Random.Range(-1f,1f),
        Random.Range(-1f, 1f),Random.Range(-1f, 1f));
        poolingManager.Get(objectName);
    }
}
