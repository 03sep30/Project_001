using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player
{
    private int hp = 100;                   //변수 Hp를 Private 하게 선언 100 입력   
    private int Power = 50;                     //변수 Power 를 Private 하게 선언 50입력

    public void Attack()                //메소드 Attack 생성
    {
        Debug.Log(this.Power + "데미지를 입혔다");
    }

    public void Damage(int damage)                   //메소드 Damage 생성
    {
        this.hp -= damage;
        Debug.Log(damage + "데미지를 입었다. ");
    }

    public int GetHp()
    {
        return hp;
    }

}
public class Test_008 : MonoBehaviour
{

    public Text playerHp;               //player hp를 보여주는 ui
    public Text player2Hp;                      //player2 hp를 보여주는 ui


    Player mPlayer = new Player();              //Player클래스 생성\<==
    Player mPlayer2 = new Player();              //Player2클래스 생성\<==

    // Start is called before the first frame update
    void Start()
    {

        //mPlayer.Attack();                               //Player 메소드 Attack 호출
        //mPlayer.Damage(30);                     //Player 메소드 Damage 호출
       // Debug.Log(mPlayer.GetHp());                 //player 의hp 를 보여준다



    }

    // Update is called once per frame
    void Update()
    {
        playerHp.text = mPlayer.GetHp().ToString();             //player 의 Hp를 UI로 표시
        player2Hp.text = mPlayer2.GetHp().ToString();             //player2 의 Hp를 UI로 표시



        if (Input.GetMouseButtonDown(0))                    //왼쪽 마우스
        {
            mPlayer.Damage(1);              //player 메소드 damage 호출
        }
        

        if (Input.GetMouseButtonDown(1))                    //오른쪽 마우스
        {
            mPlayer2.Damage(1);              //player 메소드 damage 호출
        }


    }
}

