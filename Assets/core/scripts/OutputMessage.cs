using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputMessage : MonoBehaviour
{
    //  �� ������Ʈ�� ���� ��ü��
    //  �ٸ� �ݶ��̴� (Collider, Rigidbody) �Ǵ� ������ٵ� ���� ��ü�� ������
    //  ȣ��ȴ�
    private void OnCollisionEnter(Collision collision)
    {
        //  rich Text ?
        //  �����ִ� ���ڿ�    <b>����</b> -> ���� �۾�
        Debug.Log("<b>Win!</b>");
    }

}
