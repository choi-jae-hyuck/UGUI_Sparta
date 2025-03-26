using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItemTest : MonoBehaviour
{
    private UIInventory inventory;
    public ItemObject[] itemObjects;
    public Character character;
    
    // Start is called before the first frame update
    void Start()
    {
        character = GameManager.Instance.character;
        inventory = UIManager.Instance.inventory;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddTest()
    {
        foreach (var itemObject in itemObjects)
        {
            character.itemData = itemObject.data;
            inventory.AddItem();
        }
    }
}
