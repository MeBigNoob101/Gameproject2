using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //Code to play the game^^//
    public void Quitgame()
    {
        Debug.Log("QUIT!!!");
        Application.Quit();
    }
    //Code to quit the game^^//

}
