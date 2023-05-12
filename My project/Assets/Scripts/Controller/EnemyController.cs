using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 0.5f;                                                       //적의 속도 선언
    public float rotationSpeed = 1.0f;                                              //적의 포탑 회전 속도

    public GameObject bulletPrefab;                                                 //총알 프리팹
    public GameObject enemyPivot;                                                   //적 포탑 피봇

    public Transform firePoint;                                                       //발사 위치
    public float fireRate = 1.0f;                                                    //발사  속도
    public float nextFireTime;

    private Rigidbody rb;                                                           //Rigidbody 선언
    private Transform player;                                                       //플레이어 위치 가져오기 위해 선언

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").transform;                     //Secene 에서 Player Tag를 가진 오브젝트를 가져와서 Transform 참조

    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            if (Vector3.Distance(player.position, transform.position) > 0.5f)
            {
                Vector3 direction = (player.position - transform.position).normalized;
                rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
            }


            //포탑 회전
            Vector3 targetDirection = (player.position - enemyPivot.transform.position).normalized;                         //두 벡터를 빼고 Normalized 하면 방향 값을 알려줌
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
            enemyPivot.transform.rotation = Quaternion.Lerp(enemyPivot.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            if (Time.time > nextFireTime)
            {
                nextFireTime = Time.time + 1.0f / fireRate;
                GameObject temp = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
                temp.GetComponent<ProjectileMove>().launchDirection = firePoint.localRotation * Vector3.forward;
                temp.GetComponent<ProjectileMove>().bulletType = ProjectileMove.BULLETTYPE.ENEMY;
            }
        }
    }
}
