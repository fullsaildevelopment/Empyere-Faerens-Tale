using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flexButton : MonoBehaviour
{
    UI_Inventory ui_Inventory;
    public void flex()
    {
        int i = 0;
        ui_Inventory = GameObject.Find("ItemsParent").GetComponent<UI_Inventory>().sfuii;
        foreach(KeyValuePair<BaseObject,int> item in ui_Inventory.Items)
        {
            if(item.Key.ObjectType == Identity.Item && ui_Inventory.isequp == false)
            {
                ui_Inventory.slots[i].enableButton();
            }
            if(item.Key.ObjectType == Identity.Equipment && ui_Inventory.isequp == true)
            {
                ui_Inventory.slots[i].enableButton();
            }
            i++;
        }
    }
}
