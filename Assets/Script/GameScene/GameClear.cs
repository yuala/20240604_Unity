using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClear : MonoBehaviour
{
    Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        //Transform�R���|�[�l���g��ێ����Ă���
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        //�q�ǂ��i�����������́j���Ȃ��Ȃ�����
        if (myTransform.childCount == 0)
        {
            Time.timeScale = 0f;
        }
    }
}
