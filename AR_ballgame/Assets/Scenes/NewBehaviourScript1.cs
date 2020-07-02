using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    Rigidbody rigid;
    public float force = 5;
    public GameObject ball;//要生成的物件
    public float f_Time = 1.0f; //生成間隔

    void Start()
    {
        rigid = transform.GetComponent<Rigidbody>();
    }


    void Update()
    {
        rigid.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * force);
    }

    public void ballmake()
    {
        Instantiate(ball,new Vector3 (0f , 4f , 1f),ball.transform.rotation);
    }

    public void left()
    {
        GameObject.Find("Sphere").transform.Translate(-0.1f, 0, 0);
    }
    public void right()
    {
        GameObject.Find("Sphere").transform.Translate(0.1f, 0, 0);
    }

    public void front()
    {
        GameObject.Find("Sphere").transform.Rotate(-5f, 0, 0);
    }

    public void back()
    {
        GameObject.Find("Sphere").transform.Rotate(5f, 0, 0);
    }
}

