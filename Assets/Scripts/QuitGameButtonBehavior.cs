using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGameButtonBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void OnQuitGameButtonPressed()
    {
        Debug.Log("QuitGame Pressed");
        Application.Quit();
        
        
    }
}
