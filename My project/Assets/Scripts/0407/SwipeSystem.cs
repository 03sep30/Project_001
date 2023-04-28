using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeSystem : MonoBehaviour
{

    public Vector2 initialPos; //마우스는 화면인 x, y포지션만 있기 때문테vector2
    public GameObject Character;            //캐릭터르르 선언한다.

    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) initialPos = Input.mousePosition;
        if (Input.GetMouseButtonUp(0)) Calculate(Input.mousePosition);


    }



    void Calculate(Vector3 finalPos)     //계산하는 함수를 만든다



    {
        float disX = Mathf.Abs(initialPos.x - finalPos.x);          //Mathf.abs.함수는 절대값을 구하느 함수 (거리를 구해야하기 떄문에
        float disY = Mathf.Abs(initialPos.y - finalPos.y);

        if (disX > 0 || disY > 0)                  //|| <- oㄱdmf skxksosms rjt  (%%)
        {
            if (disX > disY)
            {
                if (initialPos.x > finalPos.x)
                {
                     Character.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);
                    // Character.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);    원래 아님
                }
                else
                {
                    Character.transform.position += new Vector3(1.0f, 0.0f, 0.0f);

                }

            }


            else
            {
                if (initialPos.y > finalPos.y)
                {
                    Character.transform.position += new Vector3(0.0f, 0.0f, -1.0f);

                }
                else
                {
                    Character.transform.position += new Vector3(0.0f, 0.0f, 1.0f);

                }

            }
        }
    }
}
