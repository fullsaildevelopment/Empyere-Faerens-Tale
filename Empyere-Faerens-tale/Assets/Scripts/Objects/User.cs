using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User
{
    #region Members

    public string Name;
    public Party party = new Party();
    //public List<Item> items = new List<Item>();
    //public List<Equipment> equipment = new List<Equipment>();
    //public Inventory inventory = new Inventory();
    public int currency = 0;

    #endregion Members

    #region Getters Setters

    public string GetName()
    {
        return Name;
    }

    public void SetName(string input)
    {
        Name = input;
    }

    #endregion Getters Setters

    public User()
    {
        Name = "Null";
    }
    public User(string str)
    {
        Name = str;
    }
}