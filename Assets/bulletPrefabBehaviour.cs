using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bulletPrefabBehaviour : MonoBehaviour {

    float bulletSpeed;

	// Use this for initialization
	void Start () {
        bulletSpeed = PlayerPrefs.GetFloat("bulletSpeedMultiplier");
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.tag == "playerBullet")
        {
            Vector2 bulletPosition = transform.position;

            bulletPosition = transform.position + transform.up * bulletSpeed;

            transform.position = bulletPosition;
        }else
        {
            Vector2 bulletPosition = transform.position;

            bulletPosition = transform.position + transform.up * 1f;

            transform.position = bulletPosition;
        }
        float maxX;
        float maxY;

        float minX;
        float minY;

        maxX = Camera.main.pixelWidth;
        maxY = Camera.main.pixelHeight;

        minX = 0f;
        minY = 0f;

        if(maxX < transform.position.x || minX > transform.position.x)
        {
            Destroy(gameObject);
        }
        if(maxY < transform.position.y || minY > transform.position.y)
        {
            Destroy(gameObject);
        }

	}

    
}
