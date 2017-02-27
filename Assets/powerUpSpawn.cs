using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpSpawn : MonoBehaviour {

    public GameObject timeStop;
    public GameObject shield;
    public GameObject superSpeed;
    int rand;
    Camera cam;
    float xMin;
    float xMax;
    float yMin;
    float yMax;

	// Use this for initialization
	void Start () {
        Camera cam = Camera.main;

        xMin = 0;
        xMax = Screen.width;

        yMin = 0;
        yMax = Screen.height;

        InvokeRepeating("randomSpawner", 5f, 5f);
    }

    void randomSpawner()
    {
        rand = Random.Range(1, 3);
        
        if(rand == 1)
        {
            Vector3 pos1 = cam.ScreenToWorldPoint(new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 10));

            Instantiate(timeStop, pos1, transform.rotation);
        }

        if(rand == 2)
        {
            Vector3 pos1 = cam.ScreenToWorldPoint(new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 10));

            Instantiate(shield, pos1, transform.rotation);
        }

        if(rand == 3)
        {
            Vector3 pos1 = cam.ScreenToWorldPoint(new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 10));

            Instantiate(superSpeed, pos1, transform.rotation);
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
