using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public Character character;
    [SerializeField] public GameObject CharacterStatus;

    public void update()
    {
        if (character.Name != "Null")
        {
            this.gameObject.GetComponent<Image>().sprite = character.sprite;
        }
        else
        {
            this.gameObject.SetActive(false);
        }

        CharacterStatus.GetComponent<StatusManager>().update();
    }
}
