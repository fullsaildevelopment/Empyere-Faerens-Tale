using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyPotion : MonoBehaviour
{
    public Item potion = new Item();
    public void buy()
    {
        potion.price = 10;
        potion.Name = "Potion";
        potion.ObjectType = Identity.Item;


    }
}
