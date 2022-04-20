using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public enum ItemType
{
    Heal,
    Mana,
    Full,
    HealParty,
    ManaParty,
    FullParty,
    Damage,
    DamageParty,
    None
}
public class Item : BaseObject
{

    #region Members
    //public Identity ObjectType;
    public string Name;
    public ItemType Type;
    //Points is a percent
    public float Points;
    public int price;
    #endregion

    #region Getters Setters

    public ItemType GetTypeA()
    {
        return Type;
    }

    public void SetType(ItemType type)
    {
        Type = type;
    }

    public float GetPoints()
    {
        return Points;
    }

    public void SetPoints(int count)
    {
        Points = count;
    }

    #endregion

    public Item()
    {
        ObjectType = Identity.Item;
        Name = "null";
        Type = ItemType.None;
    }
}
