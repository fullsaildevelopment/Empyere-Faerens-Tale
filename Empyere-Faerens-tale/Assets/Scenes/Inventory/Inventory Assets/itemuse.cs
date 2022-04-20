using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemuse : MonoBehaviour
{
    [SerializeField] CharacterContainer cc;
    Character character;
    Item item;

    public void useitem()
    {
        character = cc.character;
        item = GameObject.Find("UseContext").GetComponent<itemContainer>().item;

        switch(item.Type)
        {
            case ItemType.Heal:
                character.CurrentHealth = (int)((float)character.MaxHealth * item.Points);
                break;
            case ItemType.Mana:
                character.CurrentMagic = (int)((float)character.Magic * item.Points);
                break;
            case ItemType.Damage:
                character.CurrentHealth = (int)((float)character.MaxHealth * item.Points);
                break;
            case ItemType.HealParty:
                character.CurrentHealth = (int)((float)character.MaxHealth * item.Points);
                break;
            case ItemType.DamageParty:
                character.CurrentHealth = (int)((float)character.MaxHealth * item.Points);
                break;
            case ItemType.ManaParty:
                character.CurrentMagic = (int)((float)character.Magic * item.Points);
                break;
            case ItemType.Full:
                character.CurrentMagic = character.Magic;
                character.CurrentHealth = character.MaxHealth;
                break;
            case ItemType.FullParty:
                character.CurrentMagic = character.Magic;
                character.CurrentHealth = character.MaxHealth;
                break;
        }
    }
}
