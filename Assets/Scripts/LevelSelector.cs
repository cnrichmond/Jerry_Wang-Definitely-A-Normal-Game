using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    [Header("UI Setup")]
    public Button[] levelButtons;

    void Start()
    {
        foreach (var lButton in levelButtons)
        {
            lButton.interactable = false;
        }

        int levelReached = PlayerPrefs.GetInt("levelReached", 1);
        levelReached = levelReached - 7;
        for (int i = 0; i < levelReached && i < levelButtons.Length; i++)
        {
            levelButtons[i].interactable = true;
        }

    }

    private void Update()
    {


    }


    public void LoadLevelByName(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}

