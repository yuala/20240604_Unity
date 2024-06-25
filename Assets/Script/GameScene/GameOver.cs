using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    //•Çiwall_bottomj‚É‚Ô‚Â‚©‚Á‚½
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("Result");
        Destroy(collision.gameObject);
    }


}
