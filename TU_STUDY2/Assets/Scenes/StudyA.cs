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
        studyBGameObject.AddComponent<StudyC>();

        print(studyBGameObject.name);

        var studyB = studyBGameObject.GetComponent<StudyB>();
        studyBGameObject.SendMessage("SayHello");
    }
}
