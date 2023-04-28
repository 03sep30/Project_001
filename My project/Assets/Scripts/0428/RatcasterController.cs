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
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);                                               //ȭ�鿡�� 2���� ���콺 ��ǥ�� �Է��ؼ� 3D ī�޶󿡼� Ray�� ����� �Լ�

            RaycastHit hit;

            if(Physics.Raycast(cast, out hit))                                                                          //Rast�� �浹 ������ ���� hit���� �����ش�.
            {
                Debug.Log(hit.collider.name);                                                                           //������Ʈ �̸��� ���

                Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f);                                                //Ray�� ������ ���� ���������� �����ش�.
            }
        }
    }
}
