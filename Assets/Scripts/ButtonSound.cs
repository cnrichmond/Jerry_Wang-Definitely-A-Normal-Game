using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GlobalClickSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clickSound;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (audioSource != null && clickSound != null)
            {
                audioSource.PlayOneShot(clickSound);
            }
        }
    }   
}
