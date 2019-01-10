using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverMenu : MonoBehaviour {

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        //Loads the scene 2 above in the build scenes
    }

    public void QuitGame() //Exits the game
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }


}
