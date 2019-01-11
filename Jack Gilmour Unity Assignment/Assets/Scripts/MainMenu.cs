﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Loads the scene +1 in the hierachy build
    }

    public void QuitGame () //Quits the game
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }


}
