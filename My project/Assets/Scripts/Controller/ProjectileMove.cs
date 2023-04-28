using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 launchDirection;

    private void FixedUpdate()
    {
        float moveAmount = 3 * Time.fixedDeltaTime;   //발사체 이동 속도
       transform.Translate(launchDirection * moveAmount);//해당 방향으로 이동
    }

    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.gameObject.name);           //충돌이일어 날때 이름을 가져온다,

        if (collision.gameObject.name == "Wall")
        {
            GameObject temp = this.gameObject;          //나 자신을 가져와서 temp에 입력한다
            Destroy(temp);                  //곧바로 파괴한다.
        } 
        
        if (collision.gameObject.name == "Monster")
        {
            collision.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            GameObject temp = this.gameObject;                                                    //나 자신을 가져와서 temp에 입력한다
            Destroy(temp);                                                                        //곧바로 파괴한다.
        }
    }

    private void OnTriggerEnter(Collider other)
    {      

        if (other.gameObject.tag == "Wall")
        {
            GameObject temp = this.gameObject;          //나 자신을 가져와서 temp에 입력한다
            Destroy(temp);                              //곧바로 파괴한다.
        }

        if (other.gameObject.tag == "Monster")
        {
            other.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            GameObject temp = this.gameObject;                                                //나 자신을 가져와서 temp에 입력한다
            Destroy(temp);                                                                    //곧바로 파괴한다.
        }
    }
}
