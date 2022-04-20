using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    #region Members

    public int maxCount;

    public List<BaseObject> ObjectList;

    #endregion Members

    public Inventory()
    {
        maxCount = 0;
    }

    public Inventory(int max)
    {
        maxCount = max;
        ObjectList = new List<BaseObject>(maxCount);
    }
}