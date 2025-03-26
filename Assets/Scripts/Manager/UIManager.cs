using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] public UIMainMenu mainMenu;
    [SerializeField] public UIStatus status;
    [SerializeField] public UIInventory inventory;
    

    public void OnUIMainMenu()
    {
        inventory.gameObject.SetActive(false);
        status.gameObject.SetActive(false);
    }

    public void OnUIInventory()
    {
        inventory.gameObject.SetActive(true);
        status.gameObject.SetActive(false);
       
    }

    public void OnUIStatus()
    {
        inventory.gameObject.SetActive(false);
        status.gameObject.SetActive(true);
    }

    public void CloseUIInventory()
    {
        inventory.gameObject.SetActive(false);
    }

    public void CloseUIStatus()
    {
        status.gameObject.SetActive(false);
    }
    
}
