using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player
{
    private int hp = 100;                                                         //���� HP�� private�ϰ� ���� 100 �Է�
    private int power = 50;                                                       //���� Power�� Private�ϰ� ���� 50 �Է�

    public void Attack()                                                         //�޼ҵ� Attack ����
    {
        Debug.Log(this.power + " �������� ������. ");
    }

    public void Damage(int damage)                                                //�޼ҵ� Damage ����
    {
        this.hp -= damage;
        Debug.Log(damage + " �������� �Ծ���. ");
    }

    public int GetHP()
    {
        return hp;
    }
}

public class Test_008 : MonoBehaviour
{
    public Text PlayerHP;                                                     //Player Hp�� �����ִ� UI
    public Text Player2HP;

    Player mPlayer = new Player();                                            //Player Ŭ���� ���� New <===
    Player mPlayer2 = new Player();                                           //Player2 Ŭ���� ���� New <===

    // Start is called before the first frame update
    void Start()
    {
        //mPlayer.Attack();                                                         //Player �޼ҵ� Attack ȣ��
        //mPlayer.Damage(30);                                                       //Player �޼ҵ� Damage ȣ��
       //Debug.Log(mPlayer.GetHP());                                               //Player�� HP�� �����ش�.
    }
    // Update is called once per frame
    void Update()
    {
        PlayerHP.text = "Player 1 HP : " + mPlayer.GetHP().ToString();                            //Player�� HP�� UI�� ǥ��
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