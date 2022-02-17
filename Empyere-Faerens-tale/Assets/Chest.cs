using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite chest_0;
    public int money = 10;
    protected override void OnCollect()
    {
        if(!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = chest_0;
            Debug.Log("Grant" + money + "money");
        }


    }
}
