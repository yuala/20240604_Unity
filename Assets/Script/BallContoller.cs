using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallContoller : MonoBehaviour
{

    public float speed = 5f;
    Rigidbody myrigidbody;
    // Start is called before the first frame update
    void Start()
    {
        //Rigdbodyにアクセスして変数に保持しておく
        myrigidbody = GetComponent<Rigidbody>();
        // 右斜め45度に進む
        myrigidbody.velocity = new Vector3(speed, speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
