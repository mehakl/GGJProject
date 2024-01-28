using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AudioSettings : MonoBehaviour
{
    public Slider[] volumeSlider;
    public AudioSource[] audioSource;
  

    private void Start()
    {
        volumeSlider[0].onValueChanged.AddListener(delegate { OnVolumeChangedBM(); });
        volumeSlider[1].onValueChanged.AddListener(delegate { OnVolumeChangedSFX(); });
   

    }


    public void OnVolumeChangedBM()
    {
        audioSource[0].volume = volumeSlider[0].value;
    }
    public void OnVolumeChangedSFX()
    {
        audioSource[1].volume = volumeSlider[1].value;
    }
}