using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldDurationPowerUp : MonoBehaviour {

    float shieldDuration;
    public GameObject player;
    BoxCollider2D shield;
    bool enableShield;

    void Start () {

        shieldDuration = PlayerPrefs.GetFloat("shieldDuration");
        
	}

    private void OnTriggerEnter2D(Collider2D coll)
    {

        if(coll.tag == "player")
        {
            enableShield = true;
            Invoke("shieldActivation", 0);
            Invoke("disableshield", shieldDuration);
        }

    }

    void shieldActivation()
    {
        if (enableShield == true)
        {
            
            shield = player.gameObject.AddComponent<BoxCollider2D>();
            gameObject.transform.position = player.transform.position;
           
        }
    }

    void disableShield()
    {

        enableShield = false;

    }

    private void OnCollisionEnter2D(Collision2D coll)
    {

        if(coll.collider.tag == "enemyBullet" && shield.IsTouching(coll.collider)){

            Destroy(coll.gameObject);

        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
