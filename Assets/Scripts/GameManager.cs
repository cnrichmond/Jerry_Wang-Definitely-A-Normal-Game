using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Movement Player;

    public static GameManager Instance;


    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            if (Instance != this)
            {
                Destroy(this.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        print("you died lol");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
