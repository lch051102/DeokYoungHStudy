using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalClassDemo
{
    //����
    public string Name; //�ʵ� (Ŭ���� ����)
    public string Color;
}
public class BacePlayer : MonoBehaviour
{
    private void Start()
    {
        //Ŭ������ ����ϴ� ����
        // [Ÿ��] [������] = [new] [Ÿ��()] new Ŭ����Ÿ��() -> ������ 
        AnimalClassDemo animal = new AnimalClassDemo(); //�ν��Ͻ�ȭ = ��ü
        //�ν��Ͻ��� ���� �ֳ�
        // ������ ���Ǵ°͵� �Ѿ�, ����� ��
        animal.Name = "�����";
        animal.Color = "ġ��";

        Debug.Log($"{animal.Name} {animal.Color}");
    }
}
