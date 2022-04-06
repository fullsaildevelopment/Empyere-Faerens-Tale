using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class luckypenny : MonoBehaviour
{
    public int coins;
    public TMP_Text coinUI;

    // Start is called before the first frame update
    void Start()
    {
        coinUI.text = "Coins: " + coins.ToString();
    }
    public void AddCoins() // this is the part that coins are added 
    {
        coins++;
        coinUI.text = "Coins: " + coins.ToString();
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
