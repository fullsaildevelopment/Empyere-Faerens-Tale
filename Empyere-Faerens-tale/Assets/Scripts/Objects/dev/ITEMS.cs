using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class ITEMS : BaseObject
{

    #region Members
    //public Identiy ObjectType;
    public string Name;
    public string Type;
    //Points is a percent
    public float Points;
    public int price;
    #endregion

    #region Getters Setters

    public string GetTypeA()
    {
        return Type;
    }

    public void SetType(string type)
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

    public ITEMS()
    {
        ObjectType = Identiy.Item;
        Name = "null";
    }
}