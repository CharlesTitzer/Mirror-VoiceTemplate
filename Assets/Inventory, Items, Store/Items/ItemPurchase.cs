using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPurchase : MonoBehaviour
{
    public Item Item;

    void Pickup()
    {
        if (PlayerStats.Instance.Gold >= Item.Cost)
        {
            InventoryManager.Instance.Add(Item);
            PlayerStats.Instance.ChangeGold(0 - Item.Cost);
            Destroy(gameObject);
        }

        else
        {
            print("You are broke.");
        }
    }

    private void OnMouseDown()
    {
        Pickup();
    }
}
