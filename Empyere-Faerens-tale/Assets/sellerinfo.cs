using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sellerinfo : MonoBehaviour
{

    public int ItemID;
    public Text PirceTxt;
    public Text QuantityTxt;
    public GameObject SellManager;

    void Update()
    {
       


        //seller stuff 

        PirceTxt.text = "Price: $" + SellManager.GetComponent<seller>().shopItems[2, ItemID].ToString();
        QuantityTxt.text = SellManager.GetComponent<seller>().shopItems[3, ItemID].ToString();
    }
}
