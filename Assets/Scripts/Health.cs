using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour, IHealth
{
    private int currentHealth;

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

    }

    public void Heal(int healAmount)
    {
        currentHealth += healAmount;
    }

    public bool IsDead()
    {
        return currentHealth <= 0;
    }

    public int GetCurrentHealth()
    {
        return currentHealth;
    }

    // set current health to max health
    public void SetCurrentHealth(int health)
    {
        currentHealth = health;
    }
}
