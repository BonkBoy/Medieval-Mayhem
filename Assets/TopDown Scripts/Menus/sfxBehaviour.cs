using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class sfxBehaviour : MonoBehaviour
{

    public Slider sfxVolumeSlider;
    public AudioSource sfxAudio;

    public void volumeControl()
    {
        sfxAudio.volume = sfxVolumeSlider.value;
    }

}
