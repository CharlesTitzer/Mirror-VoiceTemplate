using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemController : MonoBehaviour
{
    Item item;

    public Button RemoveButton;

    public void RemoveItem()
    {
        InventoryManager.Instance.Remove(item);
        PlayerStats.Instance.ChangeGold(item.Cost);

        Destroy(gameObject);
    }

    public void AddItem(Item newItem)
    {
        item = newItem;
    }

    public void UseItem()
    {
        switch (item.itemType)
        {
            case Item.ItemType.Potion:
                PlayerStats.Instance.IncreaseHealth(item.value);
                InventoryManager.Instance.Remove(item);
                print(item.itemType);
                Destroy(gameObject);
                break;
            case Item.ItemType.Weapon:
                //script to equip weapons
                break;
            case Item.ItemType.Armor:
                //script to equip armor
                break;
            case Item.ItemType.Loot:
                //script to give gold
                break;
        }
    }

}
