﻿using System;
using System.ComponentModel;
using System.Net;

public class Character : BaseObject
{
    #region Members

    //public Identiy ObjectType;
    public int MaxHealth,
    CurrentHealth,
    Speed,
    Attack,
    Defense,
    //This doubles as mana count and strength
    Magic,
    MagicDefense;

    public string Name;

    //All classes will be stored in a premade dictionary in global name space
    public string Class;

    //As the class this will be an enum in global namespace
    public string ElementalAffinity;

    //Equipment Memebers
    public Equipment Armor = new Equipment();
    public Equipment Weapon = new Equipment();

    //Party Character is in
    public Party currentParty = new Party();

    //Basic Attack Skill
    public Skill attack = new Skill(1);

    #endregion Members

    #region Getters & Setters

    public int GetMHP()
    {
        return MaxHealth;
    }

    public void SetMHP(int health)
    {
        MaxHealth = health;
    }

    public int GetCHP()
    {
        return CurrentHealth;
    }

    public void SetCHP(int health)
    {
        CurrentHealth = health;
    }

    public int GetSPD()
    {
        return Speed;
    }

    public void SetSPD(int spd)
    {
        Speed = spd;
    }

    public int GetATK()
    {
        return Attack;
    }

    public void SetTK(int atk)
    {
        Attack = atk;
    }

    public int GetDEF()
    {
        return Defense;
    }

    public void SetDEF(int def)
    {
        Defense = def;
    }

    public int GetMAG()
    {
        return Magic;
    }

    public void SetMAG(int mag)
    {
        Magic = mag;
    }

    public int GetMDF()
    {
        return MagicDefense;
    }

    public void SetMDF(int mdf)
    {
        MagicDefense = mdf;
    }

    public string GetClass()
    {
        return Class;
    }

    public void SetClass(string newClass)
    {
        Class = newClass;
    }

    public string GetElementalAffinity()
    {
        return ElementalAffinity;
    }

    public void SetElementalAffinity(string element)
    {
        ElementalAffinity = element;
    }

    public void SetParty(Party party)
    {
        currentParty = party;
    }

    public Party GetParty()
    {
        return currentParty;
    }

    #endregion

    public Character()
    {
        ObjectType = Identiy.Character;
        MaxHealth = 0;
        CurrentHealth = 0;
        Speed = 0;
        Attack = 0;
        Defense = 0;
        Magic = 0;
        MagicDefense = 0;
        Name = "Null";
        Class = "Null";
        ElementalAffinity = "Null";
    }
}