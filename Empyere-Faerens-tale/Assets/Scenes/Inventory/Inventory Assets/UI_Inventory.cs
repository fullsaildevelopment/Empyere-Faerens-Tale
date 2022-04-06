using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class UI_Inventory : MonoBehaviour
{
    Inventory Inventory;
    Dictionary<BaseObject, int> Items = new Dictionary<BaseObject, int>();
    InventorySlot[] slots;
    public Transform ItemsParent;
    
    // Start is called before the first frame update
    void Start()
    {
        Inventory = GameObject.Find("GameController").GetComponent<GameUser>().user.inventory;
        foreach(BaseObject obj in Inventory.ObjectList)
        {
            if(obj.ObjectType == Identiy.Item)
            {
                Item item = obj as Item;
                if(Items.ContainsKey(item) == true)
                {
                    Items[item]++;
                }
                else
                {
                    Items.Add(item, 1);
                }
            }
        }
        slots = ItemsParent.GetComponentsInChildren<InventorySlot>();
        UpdateUI();


    }
    public void UpdateUI()
    {
        for(int i = 0; i < slots.Length; i++)
        {
            if(i < Items.Count)
            {
                slots[i].addItem(Items.ElementAt(i).Key, Items.ElementAt(i).Value);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
    }


}
