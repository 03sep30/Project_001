using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 0.5f;

    private Rigidbody rb;                                       //Rigidbody ����
    private Transform player;                                  //�÷��̾� ��ġ �������� ���� ����

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").transform;                     //Secene ���� Player Tag�� ���� ������Ʈ�� �����ͼ� Transform ����

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.position,  transform.position) > 0.5f)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
        }
    }
}
