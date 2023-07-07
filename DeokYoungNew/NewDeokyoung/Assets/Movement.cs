using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
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
    private void Update()
    {
        Move();
    }

    void Move() //움직임
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }
}
