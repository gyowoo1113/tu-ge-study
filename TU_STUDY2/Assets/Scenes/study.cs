using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class study : MonoBehaviour
{
    void Start()
    {
        print("게임이 시작되었습니다.");
    }

    void Update()
    {
        print("컴포넌트가 업데이트 되었습니다.");
    }
    private void OnEnable()
    {
        print("컴포넌트가 활성화 되었습니다.");
    }

    private void OnDisable()
    {
        print("컴포넌트가 비활성화 되었습니다.");
    }

    // 언리얼 - 업데이트를 tick으로, 유니티는 별도의 업데이트가 들어감
    // 똑같은 인터벌로 계속 실행되게끔
    // 물리적인 연산, 같은주기로 업데이트 해야하는것들 
    // Update보다 이전에 호출됨
    private void FixedUpdate()
    {
        print("컴포넌트가 주기적으로 업데이트 됩니다.");
    }

    // UI 표현, 카메라 이동
    // Update 에서 실행 혹은 사용자 input에 대한 결과값 표시
    // Update 안에서 이걸 하게되면 카메라가 지글지글 거리는 등
    // 움직임이 자연스럽지 못하게 될 수 있음
    // Update 바로 뒤에 실행됨
    private void LateUpdate()
    {
        print("업데이트 뒤에 실행됩니다.");
    }
}
