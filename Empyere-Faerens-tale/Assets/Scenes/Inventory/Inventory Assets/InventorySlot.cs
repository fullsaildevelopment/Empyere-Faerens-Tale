using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    BaseObject item;
    public void addItem(BaseObject item, int count)
    {
        this.item = item;
        GameObject itemname = gameObject.transform.GetChild(1).gameObject;
        if(item.ObjectType == Identiy.Item)
        {
            Item i = (Item)item;
            itemname.GetComponent<Text>().text = i.Name;
        }
        if(item.ObjectType == Identiy.Equipment)
        {
            Equipment i = (Equipment)item;
            itemname.GetComponent<Text>().text = i.Name;
        }
        GameObject itemcount = gameObject.transform.GetChild(2).gameObject;
        itemcount.GetComponent<Text>().text = count.ToString();

    }
    public void ClearSlot()
    {
        this.item = null;
    }
}
