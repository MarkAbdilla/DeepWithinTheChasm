using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float playerHitPoints = 100f;

    public void DamagePlayer(float damage)
    {
        playerHitPoints -= damage;
        GetHealth();
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
