using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] private TextMeshProUGUI deathCountText = null;

    private int _deathCount = 0;

    private void UpdateDeathCount()
    {
        _deathCount++;
        
        deathCountText.text = "Death Count: " + _deathCount.ToString();
    }

    private void OnEnable()
    {
        Player.OnDeath += UpdateDeathCount;
    }

    private void OnDisable()
    {
        Player.OnDeath -= UpdateDeathCount;
    }
}
