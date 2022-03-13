using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BackEnd;
public class ResumeBackend : MonoBehaviour
{


    private void Start()
    {
        var bro = Backend.Initialize(true);
        if (bro.IsSuccess())
        {
            // �ʱ�ȭ ���� �� ����
            login();
          //  CustomSignUp();
        }
        else
        {
            // �ʱ�ȭ ���� �� ����
            Debug.LogError("�ʱ�ȭ ����!");
        }
    }


    void login()
    {
        BackendReturnObject bro = Backend.BMember.CustomLogin("user1", "1234");
    }

    // �α���
    public void CustomSignUp()
    {
        string id = "user1"; // ���ϴ� ���̵�
        string password = "1234"; // ���ϴ� ��й�ȣ

        var bro = Backend.BMember.CustomSignUp(id, password);
        if (bro.IsSuccess())
        {
            Debug.Log("ȸ������ ����!");
        }
        else
        {
            Debug.LogError("ȸ������ ����!");
            Debug.LogError(bro); // �ڳ��� �������̽��� �α׷� �����ݴϴ�.
        }
    }
}
