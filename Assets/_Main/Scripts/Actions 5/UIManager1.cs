using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager1 : Singleton<UIManager1>
{
    [SerializeField] private TextMeshProUGUI healthText = null;

    private void UpdateHealth(int health)
    {
        healthText.text = "HEALTH: " + health.ToString();
    }

    private void OnEnable()
    {
        Player1.OnDamage += UpdateHealth;
    }

    private void OnDisable()
    {
        Player1.OnDamage -= UpdateHealth;
    }
}
