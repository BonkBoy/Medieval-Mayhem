using UnityEngine;
using CnControls;
using UnityEngine.UI;
using System.Collections;

public class playerMovement : MonoBehaviour
{

    public GameObject player;
    public GameObject gameOverMenu;
    public GameObject mainGame;
    public GameObject moveStick;
    public GameObject pauseButton;
    public GameObject playerFireButton;

    void Update()
    {
        Vector2 playerPosition = transform.position;

        var xMove = CnInputManager.GetAxis("Horizontal") + transform.forward.magnitude * Time.deltaTime;
        var yMove = CnInputManager.GetAxis("Vertical") + transform.up.magnitude * Time.deltaTime;

        if(CnInputManager.GetAxis("Horizontal") != transform.position.x) {

            playerPosition = new Vector2(transform.position.x + xMove, transform.position.y);
            transform.position = playerPosition;

        }
        if(CnInputManager.GetAxis("Vertical") != transform.position.y)
        {
            playerPosition = new Vector2(transform.position.x, transform.position.y + yMove);
            transform.position = playerPosition;
        }
        

        var xLook = CnInputManager.GetAxis("Horizontal");
        var yLook = CnInputManager.GetAxis("Vertical");

        player.transform.eulerAngles = new Vector3(player.transform.eulerAngles.x, player.transform.eulerAngles.y, Mathf.Atan2(yLook, xLook) * Mathf.Rad2Deg);

    }

    private void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.tag == "enemyBullet")
        {
           
            Destroy(coll.gameObject);
            Destroy(gameObject);

            GameObject[] enemyClones = GameObject.FindGameObjectsWithTag("enemy");

            GameObject[] playerBullets = GameObject.FindGameObjectsWithTag("playerBullet");

            GameObject[] enemyBullets = GameObject.FindGameObjectsWithTag("enemyBullet");

            GameObject[] obstacleClones = GameObject.FindGameObjectsWithTag("obstacle");

            foreach(GameObject enemy in enemyClones)
            {
                Destroy(enemy);
            }

            foreach (GameObject obstacle in obstacleClones)
            {
                Destroy(obstacle);
            }

            foreach (GameObject bullet in playerBullets)
            {
                Destroy(bullet);
            }

            foreach(GameObject bullet in enemyBullets)
            {
                Destroy(bullet);
            }
           
            gameOverMenu.SetActive(true);
            pauseButton.SetActive(false);
            playerFireButton.SetActive(false);
            moveStick.SetActive(false);
            mainGame.SetActive(false);

        }

    }

}
