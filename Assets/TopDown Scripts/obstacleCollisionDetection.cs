using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class obstacleCollisionDetection : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.collider.tag == "obstacle")
        {
            SceneManager.LoadScene("adas");
        }

        if(coll.collider.tag == "enemy")
        {
            SceneManager.LoadScene("adas");
        }

        if(coll.collider.name == "bullet(Clone)")
        {
            Destroy(coll.gameObject);
        }
    }

}
