using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Food,
    Equipment,
    Default,
    sidequestitem,
    money
}


public enum Skills
{
    Bless,
    Cleave,
    CrossSlash,
    Earth,
    Example,
    FireStorm,
    Fire,
    FirstAid,
    Flare,
    Flood,
    Freeze,
    Ice,
    Pierce,
    Rumble,
    Slash,
    Water,
    WhiteWind
}
public enum Attributes
{
    
    Attack,
    Agility,
    Intellect,
    Stamina,
    Strength,
    Mana
}

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory System/Items/item")]
public class ItemObject : ScriptableObject
{

    public GameObject prefab;
    public bool stackable;
    public ItemType type;
    [TextArea(15, 20)]
    public string description;
    public Items data = new Items();



    public Items CreateItem()
    {
        Items newItem = new Items(this);
        return newItem;
    }
    



}

[System.Serializable]
public class Items
{
    public string Name;
    public int Id = -1;
    public ItemBuff[] buffs;
    
    public Items()
    {
        Name = "";
        Id = -1;
    }
    public Items(ItemObject item)
    {
        Name = item.name;
        Id = item.data.Id;
        buffs = new ItemBuff[item.data.buffs.Length];
        
        for (int i = 0; i < buffs.Length; i++)
        {
            buffs[i] = new ItemBuff(item.data.buffs[i].min, item.data.buffs[i].max)
            {
                attribute = item.data.buffs[i].attribute
            };
        }
    }
   


}

[System.Serializable]
public class ItemBuff
{
    public Attributes attribute;
    public int value;
    public int min;
    public int max;
    public ItemBuff(int _min, int _max)
    {
        min = _min;
        max = _max;
        GenerateValue();
    }
    public void GenerateValue()
    {
        value = UnityEngine.Random.Range(min, max);
    }
}