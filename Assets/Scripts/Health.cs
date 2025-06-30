using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    private int _currentHealth;
    private int _maxHealth;

    public Action _onDeath;
    public Action<float> _onHealthChanged;

    public void Init(int maxHealth)
    { 
        _maxHealth = maxHealth;
        _currentHealth = _maxHealth;
    }

    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;
        Mathf.Max(0, _currentHealth);

        _onHealthChanged?.Invoke(GetHealthPercentage());

        if (_currentHealth <= 0)
        {
            _onDeath?.Invoke();
        }
    }

    public void Heal(int amount)
    {
        _onHealthChanged?.Invoke(GetHealthPercentage());
    }

    public float GetHealthPercentage()
    { 
        return (float)_currentHealth / (float)_maxHealth;
    }
}
