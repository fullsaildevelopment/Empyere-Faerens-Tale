using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Identity
{
    Character,
    Item,
    Equipment,
    Enemy,
    Skill
}

public class BaseObject
{
    public Identity ObjectType;

    public BaseObject()
    {
    }
}