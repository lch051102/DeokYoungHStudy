using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;

        public Stuff(int _bul) //������
        {
            bullets = _bul;
        }
    }

    public Stuff mystuff = new Stuff(10);

    public Rigidbody bulletPrefab; //�ν��Ͻ�ȭ ��ų ���� ����
    public Transform firePos; //�߻��� ��ġ

    private void Update()
    {
        Shoots();
    }

    void Shoots() //�߻�
    {
        if (Input.GetButtonDown("Fire1") && mystuff.bullets > 0)
        {
            Rigidbody bulletInstace = Instantiate(bulletPrefab, firePos.position, firePos.rotation) as Rigidbody;
            bulletInstace.AddForce(firePos.forward * 1000);
            //
            mystuff.bullets--;

        }
    }
}
