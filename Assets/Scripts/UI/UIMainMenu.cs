using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerNameText;
    [SerializeField] private TextMeshProUGUI playerLevelText;
    [SerializeField] private TextMeshProUGUI playerGoldText;


    private void Start()
    {
        playerNameText.text = GameManager.Instance.character.Name.ToString();
        playerLevelText.text = GameManager.Instance.character.Level.ToString();
        playerGoldText.text = GameManager.Instance.character.Gold.ToString();
    }

    public void OnStatus()
    {
        UIManager.Instance.OnUIStatus();
    }

    public void OnInventory()
    {
        UIManager.Instance.OnUIInventory();
    }
}
