using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyA : MonoBehaviour
{
    private GameObject studyBGameObject;

    private void Start()
    {
        var b = transform.Find("B");
        print(b.name);
    }
}
