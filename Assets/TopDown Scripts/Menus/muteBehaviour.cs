using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class muteBehaviour : MonoBehaviour {

    bool isMute;
    
    public void mute()
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;
    } 

}
