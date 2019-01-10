using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        if(timer >= 0.0f && CanCount)
        {
            timer -= Time.deltaTime;
            uiText.text = timer.ToString("F");
        }

        else if(timer <= 0.0f && !doOnce)
        {
            CanCount = false;
            doOnce = true;
            uiText.text = "0.00";
            timer = 0.0f;
        }

    }
}