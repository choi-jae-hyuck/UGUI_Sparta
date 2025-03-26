using Unity.VisualScripting;
using UnityEngine;


public class Equipment : MonoBehaviour
{
    public Equip curEquip;
    public Transform equipParent;

    void Start()
    {
        GameManager.Instance.character.equipment = this;
    }

    public void EquipNew(ItemData data)
    {
        UnEquip();
        curEquip = data.equipPrefab.GetComponent<Equip>();
        GameManager.Instance.character.Attack += curEquip.damage;
    }

    public void UnEquip()
    {
        if(curEquip != null)
        {
            GameManager.Instance.character.Attack -= curEquip.damage;
            curEquip = null;
        }
    }
}