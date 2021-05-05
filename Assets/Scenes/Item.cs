using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Item 
{
    public int Id;
    public string Name;
    public string Description;
    public int Value;
    public Sprite Icon;
    public bool IsStackAble;
    public Item(int Id,string Name, string Description, int Value, bool IsStackAble)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;
        this.Value = Value;
        this.Icon = Resources.Load<Sprite>("Sprites/Items/" + Name);
        this.IsStackAble = IsStackAble;
    }

    public Item(Item item)
    {
        this.Id = item.Id;
        this.Name = item.Name;
        this.Description = item.Description;
        this.Value = item.Value;
        this.Icon = Resources.Load<Sprite>("Sprites/Items/" + item.Name);
        this.IsStackAble = item.IsStackAble;
    }
}
