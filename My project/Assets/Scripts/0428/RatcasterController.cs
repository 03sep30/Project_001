using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatcasterController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);                                               //화면에서 2차원 마우스 좌표를 입력해서 3D 카메라에서 Ray를 만드는 함수

            RaycastHit hit;

            if(Physics.Raycast(cast, out hit))                                                                          //Rast가 충돌 감지된 것을 hit으로 돌려준다.
            {
                Debug.Log(hit.collider.name);                                                                           //오브젝트 이름을 출력

                Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f);                                                //Ray가 쏴지는 것을 가시적으로 보여준다.
            }
        }
    }
}
