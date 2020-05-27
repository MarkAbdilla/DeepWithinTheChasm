using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float playerHitPoints = 100f;

    private void Update()
    {
        GetHealth();
    }

    public void DamagePlayer(float damage)
    {
        playerHitPoints -= damage;
        if (playerHitPoints <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }
    }

    public float GetHealth()
    {
        return playerHitPoints;
    }
}
