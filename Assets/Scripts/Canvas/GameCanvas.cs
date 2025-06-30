using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCanvas : MenuCanvas
{
    [SerializeField] private Image _healthBar;

    public void UpdateHealthBar(float current)
    {
        Debug.Log(current);
        _healthBar.fillAmount = current;
    }
}
