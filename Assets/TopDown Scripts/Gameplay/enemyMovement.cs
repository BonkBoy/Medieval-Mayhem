using UnityEngine;
using System.Collections;

public class enemyMovement : MonoBehaviour {

    public GameObject enemy;
    public GameObject[] enemyClones;

	
	void Update () {
        enemyClones = GameObject.FindGameObjectsWithTag("enemy");

        foreach (GameObject enemy in enemyClones)
        {
            enemy.transform.Rotate(0f, 0f, 20f * Time.deltaTime);
        }
        
	}
}
