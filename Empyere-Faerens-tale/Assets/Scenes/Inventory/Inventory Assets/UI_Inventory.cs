using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;


public class UI_Inventory : MonoBehaviour
{
    Inventory Inventory;
    public Dictionary<BaseObject, int> Items = new Dictionary<BaseObject, int>();
    public Dictionary<BaseObject, int> temp;
    public InventorySlot[] slots;
    public Transform ItemsParent;
    public BaseObject Empty = new BaseObject();
    [SerializeField] public UI_Inventory sfuii;
    public bool isequp;
    
    // Start is called before the first frame update
    void Start()
    {
        
        Inventory = GameObject.Find("GameController").GetComponent<GameUser>().user.inventory;
        foreach(BaseObject obj in Inventory.ObjectList)
        {
            if(obj.ObjectType == Identity.Item)
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
            if(obj.ObjectType == Identity.Equipment)
            {
                Equipment equip = obj as Equipment;
                if(Items.ContainsKey(equip) == true)
                {
                    Items[equip]++;
                }
                else
                {
                    Items.Add(equip, 1);
                }
            }
        }
        slots = ItemsParent.GetComponentsInChildren<InventorySlot>();
        foreach (InventorySlot slot in slots)
        {
            slot.disableButton();
        }
        //Debug.Log(slots.Length.ToString());
        UpdateUI();


    }
    public void UpdateUI()
    {
        temp = new Dictionary<BaseObject,int>();
        foreach(KeyValuePair<BaseObject,int> item in Items)
        {
            if(item.Key.ObjectType == Identity.Item)
                temp.Add(item.Key, item.Value);
        }
        for(int i = 0; i < slots.Length; i++)
        {
            if(i < temp.Count)
            {
                slots[i].addItem(temp.ElementAt(i).Key, temp.ElementAt(i).Value);
            }
            else
            {
                slots[i].removeItem();
            }

        }
        GameObject.Find("flex").GetComponent<Text>().text = "Use";
        ItemsParent.gameObject.GetComponent<UI_Inventory>().isequp = false;
        
    }
    public void UpdateUIEquip()
    {
        temp = new Dictionary<BaseObject, int>();
        foreach (KeyValuePair<BaseObject, int> item in Items)
        {
            if (item.Key.ObjectType == Identity.Equipment)
                temp.Add(item.Key, item.Value);
        }
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < temp.Count)
            {
                slots[i].addItem(temp.ElementAt(i).Key, temp.ElementAt(i).Value);
            }
            else
                slots[i].removeItem();
        }
        GameObject.Find("flex").GetComponent<Text>().text = "Equip";
        ItemsParent.gameObject.GetComponent<UI_Inventory>().isequp = true;
    }
    public void flex()
    {
        int i = 0;
        if (!ItemsParent.gameObject.GetComponent<UI_Inventory>().isequp)
        {
            foreach (KeyValuePair<BaseObject, int> item in Items)
            {
                if (item.Key.ObjectType == Identity.Item)
                    slots[i].enableButton();
                i++;
            }
        }
        if(ItemsParent.gameObject.GetComponent<UI_Inventory>().isequp)
        {
            foreach(KeyValuePair<BaseObject,int> item in Items)
            {
                if(item.Key.ObjectType == Identity.Equipment)
                    slots[i].enableButton();
                i++;
            }
        }
        Debug.Log(i);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
    }


}
