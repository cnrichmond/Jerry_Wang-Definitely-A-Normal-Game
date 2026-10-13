using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalAudioManager : MonoBehaviour
{
    public static GlobalAudioManager AM_Instance;

    public AudioSource Audio;

    public float volume;

    void Start()
    {
        if (AM_Instance == null)
        {
            AM_Instance = this;
        }
        else
        {
            if (AM_Instance != this)
            {
                Destroy(this.gameObject);
            }
        }

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Audio.volume = volume;
    }
}
