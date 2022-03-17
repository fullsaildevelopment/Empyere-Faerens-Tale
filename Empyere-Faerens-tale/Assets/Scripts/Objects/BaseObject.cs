using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Identiy
{
    Character,
    Item,
    Equipment,
    Enemy,
    Skill
}

public class BaseObject
{
    public Identiy ObjectType;

    public BaseObject()
    {
    }
}