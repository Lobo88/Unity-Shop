using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuySell : MonoBehaviour
{
    public List<Item> ItemsTrade= new List<Item>();
    public InventoryDatabase Items;
    public UIInventory inventoryUITrade;
    public PlayerInventory PlayerInventory;
    public InventoryComponentShop InventoryComponentShop;
    private void Awake()
    {
       
    }
    public void SellItem()
    {
        Debug.Log("sprzedalem");
        if (ItemsTrade.Count > 0 && ItemsTrade[0].Equals(PlayerInventory.ItemPlayer))
        {
            Debug.Log("przedmiot od gracza do sprzedania");
        }
    }

    public void BuyItem()
    {
        Debug.Log(ItemsTrade.Count);
        Debug.Log("kupilem");
    }
}
