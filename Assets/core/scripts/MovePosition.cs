using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  1.
//  �ݵ�� MonoBehaviour ��� Ŭ������ ��ӵǾ� �־�� �Ѵ�
//  Component !

//  2. ���ϸ�� Ŭ���� ���� �׻� ���ƾ� �մϴ�
public class MovePosition : MonoBehaviour
{
    //  ����Ƽ �÷ο���Ʈ

    //  Start ?
    //  �÷��� �Ǿ��� �� �� �� ���� ȣ��ȴ�
    void Start()
    {
        //  �ּ� ?
        //  �� �۴�� �� �� ������ �ڵ忡�� ���ܵȴ� (�޸� ���� ����)
        //  �ּ� �� ���� �ϴ� ��� : Ctrl + K, C
        //  �ּ� �� ���� �ϴ� ��� : Ctrl + K, U

        //Debug.Log("Start!");    //  Console â�� ������!
        //Debug.LogWarning("�� �Լ��� ��� ǥ���Ѵ�!");    //  �� ��ɰ� �Ȱ����� ��� ������ �޾��ش�

        ////  �� ��ɰ� ������, �� ������ ����Ǹ�
        ////  ������ �Ͻ����� �ȴ�
        //Debug.LogError("���Լ��� ���� ������ ǥ���Ѵ�");
    }

    //  Update ?
    //  �� �����Ӹ��� ȣ��ȴ�
    //  ������ ? -> FPS
    //  �׳� ��� �ݺ��ȴ�!
    void Update()
    {
        //  Vector3?
        //  X, Y, Z ���� ������ �ִ� ����ü
        //Vector3 position = transform.position;
        //position.z += 0.01f;
        //
        //transform.position = position;
        //transform.Translate(0, 0, 0.01f);

        //  ���ǹ�
        //  Input.GetKey -> ������ �ִٸ�
        //  Input.GetKeyDown -> ������ ��
        //  Input.GetKeyUp -> ������ ���� ��
        //  if (Input.GetKeyDown(KeyCode.LeftArrow))
        //if (Input.GetKey(KeyCode.A))    //  ����
        //{
        //    transform.Translate(-0.01f, 0, 0);
        //}
        //
        //if (Input.GetKey(KeyCode.D))    //  ������
        //{
        //    transform.Translate(0.01f, 0, 0);
        //}
        //
        //if (Input.GetKey(KeyCode.W))    //  ��
        //{
        //    transform.Translate(0, 0, 0.01f);
        //}
        //
        //if (Input.GetKey(KeyCode.S))    //  ��
        //{
        //    transform.Translate(0, 0, -0.01f);
        //}
        //
        ////  ȸ��!
        //if (Input.GetKey(KeyCode.Q))    //  �������� ȸ��
        //{
        //    //  f ?
        //    //  float -> �Ҽ��� ���
        //    transform.Rotate(0, 1.0f, 0);
        //}
        //
        //if (Input.GetKey(KeyCode.E))    //  ���������� ȸ��
        //{
        //    //  f ?
        //    //  float -> �Ҽ��� ���
        //    transform.Rotate(0, -1.0f, 0);
        //}

        //  ����!
        //  ť�� �ȿ� �ִ� ������Ʈ(��ǰ) �������� ���
        Rigidbody body = GetComponent<Rigidbody>();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(0, 100.0f, 0, ForceMode.Impulse);
        }

        //  �ǽ����� 2
        //  AddForce ���� �� �� �� �� �����̱�
        if (Input.GetKey(KeyCode.A))    //  �������� �����̱�
        {
            body.AddForce(-0.5f, 0, 0, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.D))    //  ���������� �����̱�
        {
            body.AddForce(0.5f, 0, 0, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.W))    //  �������� �����̱�
        {
            body.AddForce(0, 0, 0.5f, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.S))    //  �������� �����̱�
        {
            body.AddForce(0, 0, -0.5f, ForceMode.Impulse);
        }
    }
}
