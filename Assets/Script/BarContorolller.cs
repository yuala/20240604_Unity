using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarContorolller : MonoBehaviour
{

    //�v���C���[�̈ړ����x
    public float speed = 10f;
    Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // ���E�̃L�[���͂ɂ�葬�x��ύX
        myRigidbody.velocity = new Vector3(Input.GetAxis("Horizontal")*speed,0f,0f);
    }
}
