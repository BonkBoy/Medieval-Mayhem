using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class randomSpawn : MonoBehaviour
{

    public GameObject obstacle;
    public GameObject enemy;
    int levelCounter = 0;
    public Text levelNumber;
    

    void Start()
    {

        Camera cam = Camera.main;

        float xMin = 0;
        float xMax = Screen.width;

        float yMin = 0;
        float yMax = Screen.height;

        int obstacleCounter = 0;
        int enemyCounter = 0;
        levelCounter = PlayerPrefs.GetInt("levelCounter");
        
        levelNumber.text = "Level: " + levelCounter.ToString();

        if (levelCounter <= 10)
        {
            int random1 = Random.Range(1, 3);
            int random2 = Random.Range(1, 3);

            while (obstacleCounter < random1)
            {
                Vector3 pos1 = cam.ScreenToWorldPoint(new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 10));

                Instantiate(obstacle, pos1, transform.rotation);
                obstacleCounter = obstacleCounter + 1;
          
            }

            while (enemyCounter < random2)
            { 
                Vector3 pos2 = cam.ScreenToWorldPoint(new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 10));

                Instantiate(enemy, pos2, transform.rotation);
                enemyCounter = enemyCounter + 1;
                
            }
         
            
        }

        if(levelCounter > 10 && levelCounter <= 20)
        {
            int random1 = Random.Range(2, 5);
            int random2 = Random.Range(2, 5);

            while (obstacleCounter < random1)
            {
                Vector3 pos1 = cam.ScreenToWorldPoint(new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 10));

                Instantiate(obstacle, pos1, transform.rotation);
                obstacleCounter = obstacleCounter + 1;
            }

            while (enemyCounter < random2)
            {
                Vector3 pos2 = cam.ScreenToWorldPoint(new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 10));

                Instantiate(enemy, pos2, transform.rotation);
                enemyCounter = enemyCounter + 1;
            }
           

        }

        if(levelCounter > 20 && levelCounter <= 30)
        {
            int random1 = Random.Range(4, 7);
            int random2 = Random.Range(4, 7);

            while (obstacleCounter < random1)
            {
                Vector3 pos1 = cam.ScreenToWorldPoint(new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 10));

                Instantiate(obstacle, pos1, transform.rotation);
                obstacleCounter = obstacleCounter + 1;
            }

            while (enemyCounter < random2)
            {
                Vector3 pos2 = cam.ScreenToWorldPoint(new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 10));

                Instantiate(enemy, pos2, transform.rotation);
                enemyCounter = enemyCounter + 1;
            }
          

        }

        if(levelCounter > 30)
        {

            int random1 = Random.Range(6, 9);
            int random2 = Random.Range(6, 9);

            while (obstacleCounter < random1)
            {
                Vector3 pos1 = cam.ScreenToWorldPoint(new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 10));

                Instantiate(obstacle, pos1, transform.rotation);
                obstacleCounter = obstacleCounter + 1;
            }

            while (enemyCounter < random2)
            {
                Vector3 pos2 = cam.ScreenToWorldPoint(new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 10));

                Instantiate(enemy, pos2, transform.rotation);
                enemyCounter = enemyCounter + 1;
            }
            
        } 
               
    }

    void Update()
    {

        GameObject[] enemyClones = GameObject.FindGameObjectsWithTag("enemy");
        
        if (enemyClones.Length <= 0)
        {

            levelCounter = levelCounter + 1;

            PlayerPrefs.SetInt("levelCounter", levelCounter);

            SceneManager.LoadScene("adas");

        }

     
    }

}
