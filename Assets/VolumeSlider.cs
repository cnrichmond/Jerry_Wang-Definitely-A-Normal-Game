using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public Slider mainSlider;
    // Start is called before the first frame update
    void Start()
    {
        mainSlider.value = GlobalAudioManager.AM_Instance.volume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeVolume()
    {
        GlobalAudioManager.AM_Instance.volume = mainSlider.value;
    }
}
