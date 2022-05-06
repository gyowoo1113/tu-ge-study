using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPoolManager : MonoBehaviour
{
    public ManagedPrefabDatabase prefabDatabase;
    private Dictionary<string,GameObject> _prefabDic;
    private Dictionary<string,List<GameObject>> _managedObjects;

    private void Awake() 
    {
        _prefabDic = new Dictionary<string, GameObject>();
        _managedObjects = new Dictionary<string, List<GameObject>>();
        
        foreach(var ManagedPrefab in prefabDatabase.prefabs)
        {
            _prefabDic.Add(ManagedPrefab.prefabName,ManagedPrefab.prefabGameObject);
        }   
    }

    public GameObject Get(string gameObjectName)
    {
        if (_prefabDic.ContainsKey(gameObjectName)) return null;
        else
        {
            if (!_managedObjects.ContainsKey(gameObjectName))
                _managedObjects.Add(gameObjectName,new List<GameObject>());

            if (!_managedObjects[gameObjectName].Any(obj => obj.activeInHierarchy))
            {
                var possibleObject = 
                    _managedObjects[gameObjectName].FirstOrDefault(obj => !obj.activeInHierarchy);
                possibleObject.SetActive(true);
                return possibleObject;
            }
            else
            {
                var newObject = Instantiate(_prefabDic[gameObjectName]);
                _managedObjects[gameObjectName].Add(gameObject);

                return newObject;
            }
        }
    }
}
