using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSwtich : MonoBehaviour {

	public void sceneSwitch(string name)
    {
        SceneManager.LoadScene(name);
    }

}
