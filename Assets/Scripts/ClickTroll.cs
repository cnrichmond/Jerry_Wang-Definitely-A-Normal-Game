using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTroll : MonoBehaviour
{
    public GameObject trap;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    public void OnMouseDown()
    {
        trap.SetActive(true);
        gameObject.SetActive(false);
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
