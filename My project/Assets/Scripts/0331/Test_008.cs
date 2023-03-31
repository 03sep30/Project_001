using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player
{
    private int hp = 100;                                                         //변수 HP를 private하게 선언 100 입력
    private int power = 50;                                                       //변수 Power를 Private하게 선언 50 입력

    public void Attack()                                                         //메소드 Attack 생성
    {
        Debug.Log(this.power + " 데미지를 입혔다. ");
    }

    public void Damage(int damage)                                                //메소드 Damage 생성
    {
        this.hp -= damage;
        Debug.Log(damage + " 데미지를 입었다. ");
    }

    public int GetHP()
    {
        return hp;
    }
}

public class Test_008 : MonoBehaviour
{
    public Text PlayerHP;                                                     //Player Hp를 보여주는 UI
    public Text Player2HP;

    Player mPlayer = new Player();                                            //Player 클래스 생성 New <===
    Player mPlayer2 = new Player();                                           //Player2 클래스 생성 New <===

    // Start is called before the first frame update
    void Start()
    {
        //mPlayer.Attack();                                                         //Player 메소드 Attack 호출
        //mPlayer.Damage(30);                                                       //Player 메소드 Damage 호출
       //Debug.Log(mPlayer.GetHP());                                               //Player의 HP를 보여준다.
    }
    // Update is called once per frame
    void Update()
    {
        PlayerHP.text = "Player 1 HP : " + mPlayer.GetHP().ToString();                            //Player의 HP를 UI로 표시
        Player2HP.text = "Player 1 HP : " + mPlayer2.GetHP().ToString();


        if (Input.GetMouseButtonDown(0))                                                        
        {
           mPlayer.Damage(1);
        }

        if (Input.GetMouseButtonDown(1))
        {
            mPlayer2.Damage(1);
        }
    }
}