using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusManager : MonoBehaviour
{
    [SerializeField] public CharacterManager cm;
    [SerializeField] public Text Name;
    [SerializeField] public Text Health;
    [SerializeField] public GameObject HealthBar;
    [SerializeField] public Text Mana;
    [SerializeField] public GameObject ManaBar;

    Character character;

    public void update()
    {
        character = cm.character;
        Name.text = character.Name;
        
    }
}
