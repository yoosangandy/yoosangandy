using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  1.
//  반드시 MonoBehaviour 라는 클래스가 상속되어 있어야 한다
//  Component !

//  2. 파일명과 클래스 명은 항상 같아야 합니다
public class MovePosition : MonoBehaviour
{
    //  유니티 플로우차트

    //  Start ?
    //  플레이 되었을 때 단 한 번만 호출된다
    void Start()
    {
        //  주석 ?
        //  요 작대기 두 개 있으면 코드에서 제외된다 (메모 같은 느낌)
        //  주석 한 번에 하는 방법 : Ctrl + K, C
        //  주석 한 번에 하는 방법 : Ctrl + K, U

        //Debug.Log("Start!");    //  Console 창에 적힌다!
        //Debug.LogWarning("이 함수는 경고를 표시한다!");    //  위 기능과 똑같지만 경고 문구를 달아준다

        ////  위 기능과 같지만, 이 문구가 실행되면
        ////  게임이 일시정지 된다
        //Debug.LogError("이함수는 에러 문구를 표시한다");
    }

    //  Update ?
    //  매 프레임마다 호출된다
    //  프레임 ? -> FPS
    //  그냥 계속 반복된다!
    void Update()
    {
        //  Vector3?
        //  X, Y, Z 값을 가지고 있는 구조체
        //Vector3 position = transform.position;
        //position.z += 0.01f;
        //
        //transform.position = position;
        //transform.Translate(0, 0, 0.01f);

        //  조건문
        //  Input.GetKey -> 누르고 있다면
        //  Input.GetKeyDown -> 눌렀을 때
        //  Input.GetKeyUp -> 눌렀다 뗏을 때
        //  if (Input.GetKeyDown(KeyCode.LeftArrow))
        //if (Input.GetKey(KeyCode.A))    //  왼쪽
        //{
        //    transform.Translate(-0.01f, 0, 0);
        //}
        //
        //if (Input.GetKey(KeyCode.D))    //  오른쪽
        //{
        //    transform.Translate(0.01f, 0, 0);
        //}
        //
        //if (Input.GetKey(KeyCode.W))    //  앞
        //{
        //    transform.Translate(0, 0, 0.01f);
        //}
        //
        //if (Input.GetKey(KeyCode.S))    //  뒤
        //{
        //    transform.Translate(0, 0, -0.01f);
        //}
        //
        ////  회전!
        //if (Input.GetKey(KeyCode.Q))    //  왼쪽으로 회전
        //{
        //    //  f ?
        //    //  float -> 소수점 사용
        //    transform.Rotate(0, 1.0f, 0);
        //}
        //
        //if (Input.GetKey(KeyCode.E))    //  오른쪽으로 회전
        //{
        //    //  f ?
        //    //  float -> 소수점 사용
        //    transform.Rotate(0, -1.0f, 0);
        //}

        //  점프!
        //  큐브 안에 있는 컴포넌트(부품) 가져오는 방법
        Rigidbody body = GetComponent<Rigidbody>();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(0, 100.0f, 0, ForceMode.Impulse);
        }

        //  실습과제 2
        //  AddForce 으로 상 하 좌 우 움직이기
        if (Input.GetKey(KeyCode.A))    //  왼쪽으로 움직이기
        {
            body.AddForce(-0.5f, 0, 0, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.D))    //  오른쪽으로 움직이기
        {
            body.AddForce(0.5f, 0, 0, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.W))    //  앞쪽으로 움직이기
        {
            body.AddForce(0, 0, 0.5f, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.S))    //  뒤쪽으로 움직이기
        {
            body.AddForce(0, 0, -0.5f, ForceMode.Impulse);
        }
    }
}
