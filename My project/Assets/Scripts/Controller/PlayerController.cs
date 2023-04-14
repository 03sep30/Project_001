using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movespeed = 1.0f;                               //�̵� �ӵ� ���� ����
    public GameObject PlayerPivot;                              //�÷��̾� �Ǻ� ����
    Camera viewCamera;                                          //ī�޶� ���� ���� �������� ���� ����
    Vector3 velocity;                                           //�̵����� ���� �� ����
    public ProjectileController ProjectileController;          //�߻� ��Ʈ�� Ŭ���� ����
   
    // Start is called before the first frame update
    void Start()
    {
        viewCamera = Camera.main;                               //�� ��� ī�޶� �Է�
    }

    // Update is called once per frame
    void Update()
    {
        //����� 2D -> �ΰ��� 3D ��ǥ ��ȯ (���콺�� 3D �� ��� �ִ���)
        Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));
        //�ٶ� ��ġ�� ����ϱ� ���ؼ� ������Ʈ y�� �·Ḧ ���� (�ٴ��� x,z ��)
        Vector3 targetPosition = new Vector3(mousePos.x, transform.position.y, mousePos.z);
        //�޾ƿ� �Ǻ��� ���콺�� ���� �Ѵ�.
        PlayerPivot.transform.LookAt(targetPosition, Vector3.up);
        //w,s,a,d, �� ȭ��ǥ �̵� or �����ϴ� �̵��Է� ���� Horizontal, Vertical)
        velocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * movespeed;

        if(Input.GetMouseButtonDown(0))
        {
            ProjectileController.FireProjectile();
        }
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + velocity * Time.fixedDeltaTime);
        //GetComponent -> �ҽ��� �ִ� ���ӿ�����Ʈ���� <> �ȿ� �ִ� ���۳�Ʈ�� ����
        //������ �� �� ���� �̵� ��ġ ���� MovePosition �Լ��� ����
    }
}