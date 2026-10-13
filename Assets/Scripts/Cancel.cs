using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Cancel : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }
    public void OnMouseDown()
    {
        GameObject CancelButton = GameObject.FindWithTag("New tag");
        CancelButton.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
