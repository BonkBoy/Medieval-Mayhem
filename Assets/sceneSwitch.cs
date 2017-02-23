using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitch : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Invoke("finishLoading", 3f);
		
	}
	
	public void finishLoading()
    {

        SceneManager.LoadScene("StartMenu");

    }
}
