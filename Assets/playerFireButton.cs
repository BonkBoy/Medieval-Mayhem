using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFireButton : MonoBehaviour {

    public GameObject bullet;
    public GameObject bulletEmitter;

    
    public void playerShoot() {

        GameObject firedBullet = Instantiate(bullet);
        firedBullet.transform.position = bulletEmitter.transform.position;
        firedBullet.transform.rotation = bulletEmitter.transform.rotation;
        firedBullet.tag = "playerBullet";

    }
}
