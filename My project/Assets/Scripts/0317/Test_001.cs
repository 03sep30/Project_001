using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_001 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   //�ѹ��� �����
        int age;        //���� age�� ����
        age = 30;       //���� age�� 30�� ���� �Է�
        Debug.Log(age); //age�� �Էµ� ���� ����Ƽ Console â�� ������

        float height1 = 160.5f; //height1�� 160.5 �� ����
        float height2;          //height2 ����

        height2 = height1;       //height2�� height1���� �Է�
        Debug.Log(height2);      //height2�� �Էµ� ���� ����Ƽ Console â�� ������

        string name;            //name�� ����
        name = "sera";          //name�� sera �Է�
        Debug.Log(name);        //name�� �Էµ� ���� ����Ƽ Console â�� ������
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}