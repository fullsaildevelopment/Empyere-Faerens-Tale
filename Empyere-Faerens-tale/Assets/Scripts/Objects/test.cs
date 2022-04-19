using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private void Start()
    {
        User use = new User();
        Item item = new Item();
        item.price = 5;
        use.currency -= 5;
        Debug.Log(use.currency);

    }
}
