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
    [SerializeField] public Text Statuses;
    /*float HTBRatio;
    float MTBRatio;
    float barMaxWidth;*/
    bool firstStep = false;

    Character character;
    public Slider HealthSlide;
    public Slider ManaSlide;


    public void update()
    {
        
        character = cm.character;
        if (character.Name == "Null")
            this.gameObject.SetActive(false);
        Name.text = character.Name;
        if (!firstStep && character.Name != "Null")
            firststep();
        if (character.Name != "Null")
        {
            Health.text = overunder(character.CurrentHealth.ToString(), character.MaxHealth.ToString());
            Mana.text = overunder(character.CurrentMagic.ToString(), character.Magic.ToString());
            HealthSlide.value = character.CurrentHealth;
            ManaSlide.value = character.CurrentMagic;
        }





        Statuses.text = "";
    }
    public string overunder(string current, string max)
    {
        return(current + "/" + max);
    }
    public void firststep()
    {

        //HealthSlide = HealthBar.GetComponent<Slider>();
        HealthSlide.maxValue = character.MaxHealth;
        HealthSlide.value = character.CurrentHealth;


        //ManaSlide = ManaBar.GetComponent<Slider>();
        ManaSlide.maxValue = character.Magic;
        ManaSlide.value = character.CurrentMagic;
    }
}
