using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroogemcduck : ShopManager
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < shopItemsSO.Length; i++)
        {
            shopPanelsGO[i].SetActive(true);
        }
        coinUI.text = "Coins: " + coins.ToString();
       
    }

    // Update is called once per frame
    void Update()
    {
        coins++;
        coinUI.text = "Coins: " + coins.ToString();
    }
}
