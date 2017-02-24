using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;


public class enemyShootingBehaviour : MonoBehaviour
{

    public GameObject enemy;
    public GameObject bullet;
    public GameObject[] enemyClones;
    public Text score;
    int scoreMultiplier = 0;
    int finalScore = 0;
    

    void Start()
    {
        InvokeRepeating("enemyShoot", 0f, 0.7f);

        score.text = finalScore.ToString();
    }

    void Update()
    {
        scoreMultiplier = PlayerPrefs.GetInt("playerScore");
        finalScore = 100 * scoreMultiplier;
        PlayerPrefs.SetInt("finalScore", finalScore);
    }

    void enemyShoot()
    {
        enemyClones = GameObject.FindGameObjectsWithTag("enemy");

        foreach (GameObject enemy in enemyClones)
        {
            GameObject firedBullet = Instantiate(bullet);
            firedBullet.tag = "enemyBullet";
            firedBullet.transform.position = enemy.transform.position;
            firedBullet.transform.rotation = enemy.transform.rotation;
        }
     
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.tag == "playerBullet")
        {
           
            Destroy(coll.gameObject);
            Destroy(gameObject);

            scoreMultiplier = PlayerPrefs.GetInt("playerScore");

            scoreMultiplier = scoreMultiplier + 1;

            PlayerPrefs.SetInt("playerScore", scoreMultiplier);

            score.text = finalScore.ToString();
        }

    }
    
}

