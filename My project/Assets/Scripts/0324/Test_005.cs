using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_005 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�ּ� ������ Ctrl+ K + C, �ּ� Ǯ��� Ctrl+ K + U

        //for (int i = 0; i < 5; i++)                  //0���� 4���� i ���
        //{
        //    Debug.Log(i);
        //}

        //for (int i = 0; i < 10; i += 2)                //0���� 9���� ¦�� i ���
        //{
        //    Debug.Log(i);
        //}

        //for (int i = 3; i > 0; i--)                 //3���� 0���� �������鼭 i ���
        //{
        //    Debug.Log(i);
        //}

        for (int i = 0; i < 10; i++)                //0���� 9���� ¦�� ���
        {
            if(1%2 == 0)                               //%�� ������ ��
            {
                Debug.Log(i);
            }
        }

        Debug.Log("=========================================");

        int sum = 0;                             
        for (int i = 0; i < 10; i++)                               //0���� 9���� �հ� ���
        {
            sum += i;
        }
        Debug.Log(sum);

        Debug.Log("===========������==============");

        for (int i = 0; i < 10; i++)                                //i �� 1���� 10����
        {
            for(int j = 0; j < 10; j++)                             //j �� 1���� 10����
            {
                Debug.Log(i.ToString() + " x " + j.ToString() + " = " + (i * j).ToString());    // i x j = ���� ��
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}