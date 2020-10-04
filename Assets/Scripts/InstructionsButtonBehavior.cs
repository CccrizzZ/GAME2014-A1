using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class InstructionsButtonBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnInstructionButtonPressed()
    {
        Debug.Log("InstructionButton Pressed");
        SceneManager.LoadScene("GameInstructionScene");
        


    }
}
