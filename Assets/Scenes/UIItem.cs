using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class UIItem : MonoBehaviour,IPointerClickHandler
{
    public Item item;
    private Image SpriteImage;
    private UIItem SelectedItem;
    public Text Text;
    public Text SelectedItemText;
    public PlayerInventory panelPlayer;
    public UIInventory panelPlayer2;
    private void Awake()
    {
        SpriteImage = GetComponent<Image>();
      
        UpdateItem(null);
        SelectedItem = GameObject.Find("SelectedItem").GetComponent<UIItem>();
        SelectedItemText = GameObject.Find("SelectedItem").GetComponentInChildren<Text>();
        panelPlayer = GameObject.Find("Player").GetComponent<PlayerInventory>();
        panelPlayer2= GameObject.Find("Player").GetComponent<UIInventory>();
    }

public void UpdateItem(Item item)
    {
        this.item = item;
        if(this.item != null)
        {
            SpriteImage.color = Color.white;
            SpriteImage.sprite = this.item.Icon;
           if(item.IsStackAble == true && Text != null)
            {
               Text.color = Color.red;
            }
            
        }else
        {
            SpriteImage.color = Color.clear;
            
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (this.item != null)
        {
            if (SelectedItem.item != null)
            {
               
                Item clone = new Item(SelectedItem.item);
                SelectedItem.UpdateItem(this.item);
                UpdateItem(clone);
                panelPlayer.GiveItem(this.item.Id);
                Debug.Log(panelPlayer2.name.ToString());

                if (this.item.IsStackAble == true)
                {
                    Text.text = SelectedItemText.text;
                    SelectedItemText.text = "";
                   
                }
                else {
                    
                   SelectedItemText.text =  Text.text;
                    Text.text = "";
                }
                
            } else
            {
                SelectedItem.UpdateItem(this.item);
               
                if (this.item.IsStackAble == true)
                {
                    SelectedItemText.color = Color.blue;

                   
                    SelectedItemText.text = Text.text; Text.text = "";
                }
                else
                {
                    SelectedItemText.text = Text.text;
                    Text.text = "";

                } UpdateItem(null); 
            } 
        }
        else if (SelectedItem.item != null)
        {
            UpdateItem(SelectedItem.item);
            SelectedItem.UpdateItem(null);
       
            if (this.item.IsStackAble == true)
            {
                Text.text = SelectedItemText.text;
            }
            SelectedItemText.text = "";
            SelectedItemText.color = Color.clear;
        }
    }

    public void AddItemToArray()
    {
        if (this.SelectedItem.GetComponent<UIInventory>().slotPanel.name.Equals(panelPlayer.GetComponent<UIInventory>().slotPanel.name))
        {
            Debug.Log("dodawanie do tablicy" );
        }
    }
}
