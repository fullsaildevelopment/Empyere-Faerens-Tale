using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    BaseObject item;
    GameObject itemname;
    GameObject itemcount;
    GameObject itembutton;
    public void addItem(BaseObject item, int count)
    {
        this.item = item;
        itemname = gameObject.transform.GetChild(1).gameObject;
        if(item.ObjectType == Identity.Item)
        {
            Item i = (Item)item;
            itemname.GetComponent<Text>().text = i.Name;
            itemname.SetActive(true);
        }
        if(item.ObjectType == Identity.Equipment)
        {
            Equipment i = (Equipment)item;
            itemname.GetComponent<Text>().text = i.Name;
            itemname.SetActive(true) ;
        }
        itemcount = gameObject.transform.GetChild(2).gameObject;
        itemcount.GetComponent<Text>().text = count.ToString();
        itemcount.SetActive(true) ;

    }
    public void removeItem()
    {
        itemname = gameObject.transform.GetChild(1).gameObject;
        itemcount = gameObject.transform.GetChild(2).gameObject;

        itemcount.SetActive(false);
        itemname.SetActive(false);
    }
    public void disableButton()
    {
        itembutton = gameObject.transform.GetChild(4).gameObject;
        itembutton.SetActive(false);
    }
    public void enableButton()
    {
        itembutton = gameObject.transform.GetChild(4).gameObject;
        itembutton.SetActive(true);
    }
    public void ClearSlot()
    {
        this.item = null;
    }
}
