using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;

    public Toggle EnableSell;

    public InventoryItemController[] InventoryItems;


    private void Awake()
    {
        Instance = this;
    }

    public void Add(Item item)
    {
        Items.Add(item);
    }

    public void Remove(Item item)
    {
        Items.Remove(item);
    }

    public void ListItems()
    {
        //Clean content before open.
        foreach(Transform item in ItemContent)
        {
            Destroy(item.gameObject);
            print("Destroyed objects");
        }
        
        foreach (var item in Items)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);


            var itemName = obj.transform.Find("ItemName").GetComponent<TMP_Text>();
            print(itemName);
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();
            var removeButton = obj.transform.Find("RemoveButton").GetComponent<Button>();
            var itemCost = obj.transform.Find("ItemCost").GetComponent<TMP_Text>();


            itemName.text = item.itemName;
            itemCost.text = item.Cost.ToString();
            itemIcon.sprite = item.icon;

            if (EnableSell.isOn)
                removeButton.gameObject.SetActive(true);
        }

        SetInventoryItems();
    }

    public void EnableItemsSell()
    { 
        if (EnableSell.isOn)
        {
            foreach (Transform item in ItemContent)
            {
                item.Find("RemoveButton").gameObject.SetActive(true);
            }
        }
        else
        {
            foreach (Transform item in ItemContent)
            {
                item.Find("RemoveButton").gameObject.SetActive(false);
            }
        }
    }

    public void SetInventoryItems()
    {
        InventoryItems = ItemContent.GetComponentsInChildren<InventoryItemController>();

        for(int i = 0; i < Items.Count; i++)
        {
            InventoryItems[i].AddItem(Items[i]);
            print("ITem added");
        }
    }

}
