using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryDatabase : MonoBehaviour
{
    public List<Item> Items = new List<Item>();

    private void Awake()
    {
        BuildItemsDatabase();
    }

    public Item GetItem(int id)
    {
        return Items.Find(item => item.Id == id);
    }

    void BuildItemsDatabase()
    {
        Items = new List<Item>
        {
            new Item (0, "Potion", "Health", 5, true),
            new Item(1, "Knife", "Small Knife", 10, false),
            new Item(2, "Bow", "Long Bow", 45, false),
            new Item(3, "Arrows", "5 Arrows", 15, false),
            new Item(4, "Helmet", "Brown Helmet", 25, false),
        };

    }
}
