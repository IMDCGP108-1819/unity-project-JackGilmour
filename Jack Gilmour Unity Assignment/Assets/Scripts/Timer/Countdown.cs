using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Countdown : MonoBehaviour
{
    [SerializeField] private Text uiText;
    [SerializeField] private float mainTimer;

    private float timer;
    private bool CanCount = true;
    private bool doOnce = false;

    private void Start()
    {
        timer = mainTimer;
    }

    private void Update()
    {
        if(timer >= 0.0f && CanCount) //
        {
            timer -= Time.deltaTime;
//The timer will count down in Delta time based on the seconds we have since the last frame
            uiText.text = timer.ToString("F"); 
//Converting the timer to a string and the F just corresponds to creating that string into a float value
        }

        else if(timer <= 0.0f && !doOnce)
 //If the timer ever goes below zero and doOnce is equal to false then the following statement will happen:
        {
            CanCount = false;
            doOnce = true;
            uiText.text = "0.00";
            timer = 0.0f;
//When the timer reaches 0, and doOnce is equal to false, we're not counting down anymore as it's not greater than 0
//and we can't count anymore

            if(timer <= 0) //When the timer reaches 0, then the Game Over Scene will be loaded
            {
                SceneManager.LoadScene("Game Over");
            }

        }


    }
}