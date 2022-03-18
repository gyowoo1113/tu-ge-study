using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyC : MonoBehaviour
{
    private void Start() {
        var b = transform.parent;
        print(b.name);
    }
}
