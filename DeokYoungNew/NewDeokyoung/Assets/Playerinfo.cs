using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Six
{ //네임스페이스는 코드를 작성시 다른 사용자간 코드를 분리하거나 하나의 기능을 그룹화 할때 사용한다.
    //정적
    public class GlobalScore
    {
        //프로그램 전체에서 하나만 존재 해야한다.
        //전체 프로그램에서 공유해야하는 변수가 있다면 ㅈ어적으로 필드를 사용하는게 좋다.
        //Static을 사용시 공유해서 사용가능 안쓰면 사용 불가
        public static int Score; //정적 필드생성 정적(static)
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
            PlayerName = "이름없음";
        }

        public PlayerState(int _HP, int _MP, string _name)
        {
            HP = _HP;
            MP = _MP;
            PlayerName = _name;
        }

        //매소드 작성
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

        public playerDeepState DeepCopy() //매소드 (클래스 함수)
        {
            playerDeepState newCopy = new playerDeepState();
            newCopy.HP = HP;
            newCopy.MP = MP;
            return newCopy; //클래스 타입으로 리턴을 해야함
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
            player1.PlayerName = "나다 김대완";

            Debug.Log($"{player1.HP}, {player1.MP}");

            player1.ViewINFO();

            PlayerState player2 = new PlayerState();
            player2.HP = 50;
            player2.MP = 100;
            player2.PlayerName = "나다 한현규";

            player2.ViewINFO();

            //스포너 ?랜덤캐릭 셀렉
            PlayerState Hero = new PlayerState(500, 500, "김영웅형 등장");
            Hero.ViewINFO();

            Debug.Log($"{GlobalScore.Score}");

            //얕은복사 깊은복사

            PlayerState SampleA = new PlayerState();
            SampleA.HP = 100;
            SampleA.MP = 200;

            PlayerState SampleB = SampleA;
            SampleB.MP = 500;

            Debug.Log($"{SampleA.HP} {SampleB.MP}"); //100 200이라고 예측 하지만 100 500이 뜸
            Debug.Log($"{SampleB.HP} {SampleA.MP}"); //100 500


            //깊은 복사 과정
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
