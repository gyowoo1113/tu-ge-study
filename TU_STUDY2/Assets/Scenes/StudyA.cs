using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyA : MonoBehaviour
{
    private GameObject studyBGameObject;

    private void Start()
    {
        studyBGameObject = GameObject.Find("B");
        print(studyBGameObject.name);
    }
}
