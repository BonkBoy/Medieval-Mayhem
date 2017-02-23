using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class volumeBehaviour : MonoBehaviour
{

    public Slider musicVolumeSlider;
    public AudioSource volumeAudio;

    public void volumeControl()
    {
        volumeAudio.volume = musicVolumeSlider.value;
    }

}
