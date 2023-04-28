using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{

    float rotSpeed = 0;     //변수 회전 속도

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10000;

        }
        transform.Rotate(0, this.rotSpeed * Time.deltaTime, 0);       //transform 은 캐릭터의 위치 컨퍼넨트
                                                                        //rotate 함수는 회전을 시켜주는 함수
                                                                        //프레인마다 1%씩 속도 감속
        rotSpeed *= 0.99f;

    }
}
