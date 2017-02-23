using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class returnScene : MonoBehaviour
{

    public void returner(string name)
    {
        SceneManager.LoadScene(name);
    }

}