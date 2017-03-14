using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeStopPowerUp : MonoBehaviour {

    float timeStopDuration;
    public GameObject[] enemies;
    public GameObject[] bullets;
    bool disableTime;

    void Start()
    {
        timeStopDuration = PlayerPrefs.GetFloat("timeStopDuration");
        enemies = GameObject.FindGameObjectsWithTag("enemy");
        bullets = GameObject.FindGameObjectsWithTag("enemyBullet");
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.tag == "player")
        {
            disableTime = true;
            Invoke("timeStop", 0);
            Invoke("enableTime", timeStopDuration);
        }

    }

    void timeStop()
    {

        if (disableTime == true)
        {
            foreach (GameObject enemy in enemies)
            {
                RigidbodyConstraints2D enemyBody = enemy.GetComponent<RigidbodyConstraints2D>();
                enemyBody = RigidbodyConstraints2D.FreezeAll;
            }

            foreach (GameObject bullet in bullets)
            {
                RigidbodyConstraints2D bulletBody = bullet.GetComponent<RigidbodyConstraints2D>();
                bulletBody = RigidbodyConstraints2D.FreezeAll;
            }

        }
    }

    void enableTime()
    {
        disableTime = false;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
