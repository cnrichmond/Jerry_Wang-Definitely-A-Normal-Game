using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
   [SerializeField]private int currentBuildIndexNumber;
   [SerializeField]private int nextBuildIndexNumber;
    public SpeedrunTimer speedRun;
    public void CompleteLevel(int currentLevelBuildIndex)
    {
        int levelReached = 0;
        //checking if level reached is stored
        if (PlayerPrefs.HasKey("levelReached"))
        {
            levelReached = PlayerPrefs.GetInt("levelReached", currentBuildIndexNumber);
        }

        if (currentLevelBuildIndex >= levelReached)
        {
            PlayerPrefs.SetInt("levelReached", currentLevelBuildIndex + 1);
            PlayerPrefs.Save();
        }
        if (speedRun != null)
        {
            if (!PlayerPrefs.HasKey("SpeedRunBestTime"))
            {
                PlayerPrefs.SetFloat("SpeedRunBestTime", speedRun.currentTime);
            }
            else if (speedRun.currentTime < PlayerPrefs.GetFloat("SpeedRunBestTime"))
            {
                PlayerPrefs.SetFloat("SpeedRunBestTime", speedRun.currentTime);
            }
        }
    }
   
    // Start is called before the first frame update
    void Start()
    {
        currentBuildIndexNumber = SceneManager.GetActiveScene().buildIndex;
        nextBuildIndexNumber = currentBuildIndexNumber + 1;
        PlayerPrefs.Save();
    }
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            CompleteLevel(nextBuildIndexNumber);
            SceneManager.LoadScene(nextBuildIndexNumber);

        }
    }

}

