using UnityEngine;
using CnControls;
using System.Collections;

public class playerMobility : MonoBehaviour
{

    Transform playerPos;
    public GameObject player;
    public Rigidbody2D playerBody;
    public GameObject bullet;
    public Rigidbody2D bulletBody;
    public Collider2D bulletCollider;


    void Awake()
    {
        playerPos = GetComponent<Transform>();
    }

    

    void FixedUpdate()
    {
        var x = CnInputManager.GetAxis("CameraX");
        var y = CnInputManager.GetAxis("CameraY");

        playerPos.transform.eulerAngles = new Vector3(playerPos.transform.eulerAngles.x, playerPos.transform.eulerAngles.y, Mathf.Atan2(y, x) * Mathf.Rad2Deg);

        playerShoot();
    }


    public void playerShoot()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Vector2 shootDirection = player.transform.eulerAngles;
            Instantiate(bullet, player.transform.position, player.transform.rotation);
            bulletBody.AddForce(transform.forward, ForceMode2D.Force);
        }
    }

}