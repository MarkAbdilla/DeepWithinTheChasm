using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] float countdownTimerInSeconds = 60f;

    void Update()
    {
        countdownTimerInSeconds -= Time.deltaTime;
        if(countdownTimerInSeconds <= 0)
        {
            Debug.Log("Game Over!");
        }
    }
}
