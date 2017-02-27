using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldDurationPowerUp : MonoBehaviour {

    float shieldDuration;
    public GameObject player;
    BoxCollider2D shield;
    bool disableShield = true;

    void Start () {

        shieldDuration = PlayerPrefs.GetFloat("shieldDuration");
        
	}

    private void OnTriggerEnter2D(Collider2D coll)
    {

        if(coll.tag == "player")
        {

            Invoke("shieldActivation", 0);
            Invoke("enableshield", shieldDuration);
            disableShield = true;

        }

    }

    void shieldActivation()
    {
        if (disableShield == true)
        {
            
            shield = player.gameObject.AddComponent<BoxCollider2D>();
            gameObject.transform.position = player.transform.position;
           
        }
    }

    void enableShield()
    {

        disableShield = false;

    }

    private void OnCollisionEnter2D(Collision2D coll)
    {

        if(coll.collider.tag == "bullet" && shield.IsTouching(coll.collider)){

            Destroy(coll.gameObject);

        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
