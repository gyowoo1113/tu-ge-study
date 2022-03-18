using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyA : MonoBehaviour
{
    public GameObject studyBGameObject;

    private void Start()
    {
        print(studyBGameObject.name);
    }
}
