using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
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

    public float speed;
    public float turnSpeed;

    public Rigidbody bulletPrefab; //�ν��Ͻ�ȭ ��ų ���� ����
    public Transform firePos; //�߻��� ��ġ
    private void Update()
    {
        Movement();
        Shoot();
    }

    void Movement() //������
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }

    void Shoot() //�߻�
    {
        if(Input.GetButtonDown("Fire1") && mystuff.bullets > 0)
        {
            Rigidbody bulletInstace = Instantiate(bulletPrefab, firePos.position, firePos.rotation) as Rigidbody;
            bulletInstace.AddForce(firePos.forward * 1000);
            //
            mystuff.bullets--;

        }
    }
}
