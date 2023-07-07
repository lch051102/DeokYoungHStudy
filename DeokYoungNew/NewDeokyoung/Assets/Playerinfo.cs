using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Six
{ //���ӽ����̽��� �ڵ带 �ۼ��� �ٸ� ����ڰ� �ڵ带 �и��ϰų� �ϳ��� ����� �׷�ȭ �Ҷ� ����Ѵ�.
    //����
    public class GlobalScore
    {
        //���α׷� ��ü���� �ϳ��� ���� �ؾ��Ѵ�.
        //��ü ���α׷����� �����ؾ��ϴ� ������ �ִٸ� ���������� �ʵ带 ����ϴ°� ����.
        //Static�� ���� �����ؼ� ��밡�� �Ⱦ��� ��� �Ұ�
        public static int Score; //���� �ʵ���� ����(static)
    }
    public class PlayerState
    {
        public int HP;
        public int MP;
        public string PlayerName;

        public PlayerState()
        {
            HP = 100;
            MP = 100;
            PlayerName = "�̸�����";
        }

        public PlayerState(int _HP, int _MP, string _name)
        {
            HP = _HP;
            MP = _MP;
            PlayerName = _name;
        }

        //�żҵ� �ۼ�
        public void ViewINFO()
        {
            GlobalScore.Score++;
            Debug.Log($"{HP}{MP}{PlayerName}");
        }
    }

    public class playerDeepState
    {
        public int HP;
        public int MP;

        public playerDeepState DeepCopy() //�żҵ� (Ŭ���� �Լ�)
        {
            playerDeepState newCopy = new playerDeepState();
            newCopy.HP = HP;
            newCopy.MP = MP;
            return newCopy; //Ŭ���� Ÿ������ ������ �ؾ���
        }
    } 
    public class Playerinfo : MonoBehaviour
    {
        void Start()
        {

            PlayerState player0 = new PlayerState();
            player0.ViewINFO();

            PlayerState player1 = new PlayerState();
            player1.HP = 100;
            player1.MP = 50;
            player1.PlayerName = "���� ����";

            Debug.Log($"{player1.HP}, {player1.MP}");

            player1.ViewINFO();

            PlayerState player2 = new PlayerState();
            player2.HP = 50;
            player2.MP = 100;
            player2.PlayerName = "���� ������";

            player2.ViewINFO();

            //������ ?����ĳ�� ����
            PlayerState Hero = new PlayerState(500, 500, "�迵���� ����");
            Hero.ViewINFO();

            Debug.Log($"{GlobalScore.Score}");

            //�������� ��������

            PlayerState SampleA = new PlayerState();
            SampleA.HP = 100;
            SampleA.MP = 200;

            PlayerState SampleB = SampleA;
            SampleB.MP = 500;

            Debug.Log($"{SampleA.HP} {SampleB.MP}"); //100 200�̶�� ���� ������ 100 500�� ��
            Debug.Log($"{SampleB.HP} {SampleA.MP}"); //100 500


            //���� ���� ����
            playerDeepState SampleDA = new playerDeepState();
            SampleDA.HP = 100;
            SampleDA.MP = 200;

            playerDeepState SampleDB = SampleDA.DeepCopy();
            SampleDB.MP = 500;

            Debug.Log($"{SampleDA.HP} {SampleDB.MP}"); //100 500
            Debug.Log($"{SampleDB.HP} {SampleDA.MP}"); //100 200
        }
    }
}
