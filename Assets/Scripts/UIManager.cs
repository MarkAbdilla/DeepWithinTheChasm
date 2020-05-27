using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] TextMeshProUGUI timerText;

    PlayerHealth playerHealth;
    Timer timer;


    private void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
        timer = FindObjectOfType<Timer>();
    }

    private void Update()
    {
        healthText.text = playerHealth.GetHealth().ToString();
        timerText.text = timer.GetTimeLeft().ToString();
    }
}
