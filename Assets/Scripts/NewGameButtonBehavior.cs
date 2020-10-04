using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewGameButtonBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnNewGameButtonPressed()
    {
        Debug.Log("NewGameButton Pressed");
        SceneManager.LoadScene("GamePlayScene");
        
        
    }

}
