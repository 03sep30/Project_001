using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//if 제어문
public class Test_003 : MonoBehaviour
{
    public int herNum = 1;                 //정수 herNum 선언 후 1을 입력
    // Start is called before the first frame update
    void Start()
    {
       

        if (herNum == 1)                    //조건식 herNum 이 1 일 경우 안에 로직을 실행한다.

        {
            Debug.Log ("체력을 50 회복");         //Console.Log창에 창에 조건이 만족됭 경우 해당 내용을 표시한다.

        }
        else
           {
            Debug.Log ("체력 -50 ");         //Console.Log창에 창에 조건이 만족됭 경우 해당 내용을 표시한다.

        }


    }


























    // Update is called once per frame
    void Update()
    {
        
    }
}
