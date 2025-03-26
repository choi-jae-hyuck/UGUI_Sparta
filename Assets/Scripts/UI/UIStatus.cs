using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI attackText;
    [SerializeField]private TextMeshProUGUI defenseText;
    [SerializeField]private TextMeshProUGUI healthText;
    [SerializeField]private TextMeshProUGUI criticalText;


    private void OnEnable()
    {
        attackText.text = GameManager.Instance.character.Attack.ToString();
        defenseText.text = GameManager.Instance.character.Defense.ToString();
        healthText.text = GameManager.Instance.character.Health.ToString();
        criticalText.text = GameManager.Instance.character.Critical.ToString();
    }

    public void BackButton()
    {
        UIManager.Instance.CloseUIStatus();
    }
}
