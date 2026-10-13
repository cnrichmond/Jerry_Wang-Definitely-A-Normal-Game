using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [Header("LevelNumber")]
    public int currentLevelNumber;

    public void MarkLevelAsComplete()
    {
        
        int furthestLevel = PlayerPrefs.GetInt("FurthestLevelNumber", 1);

        
        int nextLevelNumber = currentLevelNumber + 1;

       
        if (nextLevelNumber > furthestLevel)
        {
            PlayerPrefs.SetInt("FurthestLevelNumber", nextLevelNumber);
            PlayerPrefs.Save();
        }

       
        SceneManager.LoadScene("LevelSelector");
    }
}
