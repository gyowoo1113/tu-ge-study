using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyA : MonoBehaviour
{
    private GameObject studyBGameObject;

    private void Start()
    {
        studyBGameObject = new GameObject("B");
        studyBGameObject.AddComponent<StudyB>();

        print(studyBGameObject.name);

        var studyB = studyBGameObject.GetComponent<StudyB>();
        studyB.SendMessage("SayHello");
    }
}
