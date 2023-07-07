using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalClassDemo
{
    //참조
    public string Name; //필드 (클래스 변수)
    public string Color;
}
public class BacePlayer : MonoBehaviour
{
    private void Start()
    {
        //클래스를 사용하는 공식
        // [타입] [변수명] = [new] [타입()] new 클래스타입() -> 생성자 
        AnimalClassDemo animal = new AnimalClassDemo(); //인스턴스화 = 객체
        //인스턴스가 뭐가 있냐
        // 복제된 사용되는것들 총알, 사용자 등
        animal.Name = "고양이";
        animal.Color = "치즈";

        Debug.Log($"{animal.Name} {animal.Color}");
    }
}
