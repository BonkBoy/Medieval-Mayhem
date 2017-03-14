using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bulletPrefabBehaviour : MonoBehaviour {

    float bulletSpeed;
    Texture2D bulletSkin;
    string bulletSkinPath;

    // Use this for initialization
    void Start () {
        bulletSpeed = PlayerPrefs.GetFloat("bulletSpeedMultiplier");

        bulletSkin = gameObject.GetComponent<Texture2D>();
        bulletSkinPath = PlayerPrefs.GetString("bulletSkin");
    }
    
	
	// Update is called once per frame
	void Update () {
        if (gameObject.tag == "playerBullet")
        {
            WWW imageConversion = new WWW(bulletSkinPath);

            imageConversion.LoadImageIntoTexture(bulletSkin);

            bulletSpeed = PlayerPrefs.GetFloat("bulletSpeedMultiplier");

            Vector2 bulletPosition = transform.position;

            bulletPosition = transform.position + (transform.up * bulletSpeed);

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
