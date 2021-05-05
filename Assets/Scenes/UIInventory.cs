using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    public List<UIItem> uIItem = new List<UIItem>();
    public GameObject slotPrefab;
    public Transform slotPanel;
    public int numberOfSlots = 8;

    private void Awake()
    {
        for (int i = 0; i <numberOfSlots; i++)
        {
            GameObject instance = Instantiate(slotPrefab);
            instance.transform.SetParent(slotPanel);
            uIItem.Add(instance.GetComponentInChildren<UIItem>());
        }
    }

    public void UpdateSlots(int slot, Item item)
    {
        uIItem[slot].UpdateItem(item);
        
    }

    public void AddNewItem(Item item)
    {
        UpdateSlots(uIItem.FindIndex(i => i.item == null), item);
    }
    public void RemoveItem(Item item)
    {
        UpdateSlots(uIItem.FindIndex(i => i.item == item), null);
    }
}
