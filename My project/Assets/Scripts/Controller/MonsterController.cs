using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public int Monster_hp = 5;

    public void Monster_Damaged(int damage)     //데미지를 받는 함수 (인수 int)
    {
        Monster_hp -= damage;
        if (Monster_hp <= 0 )
        {
            GameObject temp = this.gameObject;      //나ㅏ 자ㄱ신을 가져와서 temp에
            Destroy( temp );
        }
    }
}
