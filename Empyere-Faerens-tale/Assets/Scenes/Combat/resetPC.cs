using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetPC : MonoBehaviour
{
    public void resetChars()
    {
        foreach (Character c in GameObject.Find("GameController").GetComponent<GameUser>().user.party.active_characters)
        {
            Character ch = c;
            if(ch.Name != "Null")
            {
                ch.CurrentHealth = ch.MaxHealth;
            }
        }
    }
}
