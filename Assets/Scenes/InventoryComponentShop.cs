using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryComponentShop : MonoBehaviour
{
    public List<Item> ItemsShop = new List<Item>();
    public InventoryDatabase ItemShop;
    public UIInventory inventoryUI;
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            Debug.Log(ItemsShop.Count );
        }

    }
    public void Start()
    {
        GiveItem(0);
        GiveItem(1);
        GiveItem(2);
        //RemoveItem(1);
    }
    public void GiveItem(int id)
    {
        Item itemToAdd = ItemShop.GetItem(id);
        ItemsShop.Add(itemToAdd);
        inventoryUI.AddNewItem(itemToAdd);
        Debug.Log("add item : " + itemToAdd.Name);
    }

    public Item CheckForItem(int id)
    {
        return ItemsShop.Find(item => item.Id == id);
    }

    public void RemoveItem(int id)
    {
        Item item = CheckForItem(id);
        if (item != null)
        {
            ItemsShop.Remove(item);
            inventoryUI.RemoveItem(item);
            Debug.Log("remove : " + item.Name);
        }
    }
  
}
