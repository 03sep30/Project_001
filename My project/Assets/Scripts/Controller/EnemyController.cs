using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 0.5f;

    private Rigidbody rb;                                       //Rigidbody 선언
    private Transform player;                                  //플레이어 위치 가져오기 위해 선언

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").transform;                     //Secene 에서 Player Tag를 가진 오브젝트를 가져와서 Transform 참조

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
