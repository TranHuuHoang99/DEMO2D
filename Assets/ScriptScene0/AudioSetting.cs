using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSetting : MonoBehaviour
{
    public AudioSource audioSource;

    private float musicVolume = 1f;

    private void Update(){
        audioSource.volume = musicVolume;
    }
    public void UpdateVolume(float volume){
        musicVolume = volume;
    }
}
