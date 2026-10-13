using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpeedrunTimer : MonoBehaviour
{
    public TextMeshProUGUI TimerText;
    public float currentTime = 0f;
    public TextMeshProUGUI bestTimerLabel;
    public TextMeshProUGUI bestTimerText;
    

    public bool startTimer = true;
    // Start is called before the first frame update
    void Start()
    {
        bestTimerLabel.gameObject.SetActive(false);

       if(PlayerPrefs.HasKey("SpeedRunBestTime"))
        {
            bestTimerLabel.gameObject.SetActive(true);
            float bestTime = PlayerPrefs.GetFloat("SpeedRunBestTime");
            int minutes = (int)bestTime / 60;
            int seconds = (int)bestTime - 60 * minutes;
            int milliseconds = (int)(1000 * (bestTime - minutes * 60 - seconds));
            bestTimerText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (startTimer)
        {
            currentTime += Time.deltaTime;
            int minutes = (int)currentTime / 60;
            int seconds = (int)currentTime - 60 * minutes;
            int milliseconds = (int)(1000 * (currentTime - minutes * 60 - seconds));
            TimerText.text =  string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
        }

      
    }
}
