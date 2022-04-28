using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterContainer : MonoBehaviour
{
    public Character character = new Character();
    public Text Name;
    public int i;

    public void update()
    {
        if (character.Name != "Null")
        {
            Name.text = character.Name;
        }
        else
        {
            this.gameObject.SetActive(false);
        }

    }
}
