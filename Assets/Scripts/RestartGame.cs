using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void ResetProgress()
    {
        PlayerPrefs.DeleteKey("levelReached");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
    public void OnMouseDown()
    {
        GameObject CancelButton = GameObject.FindWithTag("New tag");
        CancelButton.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
