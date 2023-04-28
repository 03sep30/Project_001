using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public Vector3 launchDirection;         //발사 방향 벡터 선언
    public GameObject projectile;           //발사체 프리맵 선언
    // Start is called before the first frame update
   public void FireProjectile()         //발사 함수 선언

    {
        GameObject temp = (GameObject)Instantiate(projectile);      //발사체 프리맵을 생성시키고 TEMP에 입력
                                                                    //Instantiate함수는 gameobject
        temp.transform.position = this.gameObject.transform.position;
        temp.GetComponent<ProjectileMove>().launchDirection = transform.forward;

        Destroy(temp, 10f);     //발사체 만든 것이 10초 후 사라진다


    }

  
    
}
