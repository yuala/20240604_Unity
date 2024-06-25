using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    //�X�R�A
    public int score = 10;
    private BlockGenerator blockGenerator;
    //�����ƂԂ��������ɌĂ΂��
    private void Start()
    {
        blockGenerator = FindObjectOfType<BlockGenerator>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (ScoreScript.instance != null)
        {
            ScoreScript.instance.ScoreManager(score);
        }
        else
        {
            Debug.LogError("ScoreScript�̃C���X�^���X������܂���B");
        }
        //�u���b�N���Ԃ������ɐ��������J�E���g�����炵�Ă���
        blockGenerator.BlockDestroyed();
        //�Q�[���I�u�W�F�N�g���폜����
        Destroy(gameObject);
    }
}
