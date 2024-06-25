using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    //壁（wall_bottom）にぶつかった時
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("Result");
        Destroy(collision.gameObject);
    }


}
