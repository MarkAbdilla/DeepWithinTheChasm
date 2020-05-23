using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] float countdownTimerInSeconds = 60f;

    private bool timerStarted = false;
    DeathHandler deathHandler;

    private void Start()
    {
        deathHandler = FindObjectOfType<DeathHandler>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            timerStarted = true;
        }
    }

    private void Update()
    {
        if (timerStarted == true)
        {
            BeginTimer();
        }
    }

    private void BeginTimer()
    {
        countdownTimerInSeconds -= Time.deltaTime;
        if (countdownTimerInSeconds <= 0)
        {
            deathHandler.HandleDeath();
        }
    }
}
