using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;

        public Stuff(int _bul) //생성자
        {
            bullets = _bul;
        }
    }

    public Stuff mystuff = new Stuff(10);

    public float speed;
    public float turnSpeed;

    public Rigidbody bulletPrefab; //인스턴스화 시킬 원본 파일
    public Transform firePos; //발사할 위치
    private void Update()
    {
        Movement();
        Shoot();
    }

    void Movement() //움직임
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }

    void Shoot() //발사
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
