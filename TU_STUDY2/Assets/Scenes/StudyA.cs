using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyA : MonoBehaviour
{
    private GameObject studyBGameObject;

    private void Start()
    {
        studyBGameObject = new GameObject("B");
        print(studyBGameObject.name);
        Destroy(studyBGameObject);
    }
}
