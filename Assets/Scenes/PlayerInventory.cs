using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public List<Item> ItemsPlayer = new List<Item>();
    public InventoryDatabase ItemPlayer;
    public UIInventory inventoryUI;
    public int Money =100;
    public InventoryComponentShop inventoryComponentShop;

    public void GiveItem(int id)
    {
        Item itemToAdd = ItemPlayer.GetItem(id);
        ItemsPlayer.Add(itemToAdd);
        inventoryUI.AddNewItem(itemToAdd);
        Debug.Log("add item : " + itemToAdd.Name);
    }
    private void Start()
    {
        GiveItem(1);
    }
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            Debug.Log("interakt");
            Debug.Log(ItemsPlayer.Count + "+");
        }

    }
}
