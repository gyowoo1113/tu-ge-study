using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyA : MonoBehaviour
{
    private GameObject studyBGameObject;

    private void Start()
    {
        // 컴포넌트 찾은 뒤 gameObject 연결
        // 단 한번만 사용되는 곳에서 쓰기엔 편리함
        // 단 Update 등에선 GameObject에서 있는 Hieracy를 모두 찾아보는 것이기 때문에
        // 퍼포먼스 문제가 발생할 수 있음
        studyBGameObject = GameObject.FindObjectOfType<StudyB>().gameObject;
        print(studyBGameObject.name);
    }
}
