using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody myrigidbody;
    // Start is called before the first frame update
    void Start()
    {
        //Rigdbod�ɃA�N�Z�X���ĕϐ��ɕێ����Ă���
        myrigidbody = GetComponent<Rigidbody>();
        //�E�΂�45�x�ɐi��
        myrigidbody.velocity = new Vector3(speed, speed, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
