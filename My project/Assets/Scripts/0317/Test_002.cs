using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_002 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int answer;     //정수 answer 선언
        answer = 1 + 2;  //answer 에 1+2 연산 값을 입력
        Debug.Log(answer);   //answer를 Debug.Log에 출력시킨다. 


        int n1 = 8;   //정수 n1 선언 후 값 8을 입력
        int n2 = 9;  // 정수 n2 선언 후 값 9를 입력
        int answer2;   //정수answer2 선언
        answer2 = n1 + n2;  //정수 answer2에 n1과 n2 더한 값을 입력
        Debug.Log(answer2);  //answer2를 Debug.Log에 출력 시킨다.

        int answer3 = 10;   //정수 answer3 선언 후 값 10 입력
        answer3 += 5;//정수answer3에 값 +5 값을 추가 (answer3 = answer3 + 5) (축약용)
        Debug.Log(answer3);    //answer3 를 Debug.Log에 출력 시킨다.
        answer3++;           //정수 answer3에 +1 값을 추가 ( answer3 = answer3 + 1) (많이 사용해서 생긴 것.)
        Debug.Log(answer3);   // answer3를 Debug.Log에 출력 시킨다.


        string str = "Happy ";   //문자열 str에  "happy" 입력
        string str2 = "birthday";   //문자열 str2에 "birthday" 입력

        str += str2;        //str = str + str2;
        Debug.Log(str);     //str 더 한 값을 Debug.Log 에 출력 시킨다.

        string message = str + answer3;     //문자열 message를 선언하고 (string)값 str과 (int) 값 answer3를 더한다.
        Debug.Log(message);         //message 값을 Debug.Log에 출력 시킨다. 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
