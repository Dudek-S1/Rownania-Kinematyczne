using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    //s=3m
    //a= -20m/s^2
    public Rigidbody ball;
    //u = ?
    //v = 0m/s

    //prêdkoœæ pocz¹tkowa = 10.95
    // Start is called before the first frame update
    void Start()
    {
        ball.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Jumpp();
        }
        


    }
    void Jumpp()
    {
        Physics.gravity = Vector3.up * -20;
        ball.useGravity = true;
        transform.Translate(Vector3.up * 10.95f);
    }
}
