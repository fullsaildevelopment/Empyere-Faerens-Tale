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
    float HTBRatio;
    float MTBRatio;
    float barMaxWidth;
    bool firstStep = false;

    Character character;

    public void update()
    {
        
        character = cm.character;
        if (character.Name == "Null")
            this.gameObject.SetActive(false);
        Name.text = character.Name;
        if (!firstStep)
            firststep();

        float missingHp = character.MaxHealth - character.CurrentHealth;
        float missingMp = character.Magic - character.CurrentMagic;

        /*Rect rect = HealthBar.GetComponent<RectTransform>().rect;
        HealthBar.GetComponent<Image>().sprite.rect.Set(rect.x, rect.y, barMaxWidth - (HTBRatio * missingHp), rect.height);
        HealthBar.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, barMaxWidth - (HTBRatio * missingHp));
        
        rect = ManaBar.GetComponent<Image>().sprite.rect;
        ManaBar.GetComponent<Image>().sprite.rect.Set(rect.x, rect.y, barMaxWidth - (MTBRatio * missingMp), rect.height);*/
        Health.text = overunder(character.CurrentHealth.ToString(), character.MaxHealth.ToString());
        Mana.text = overunder(character.CurrentMagic.ToString(), character.Magic.ToString());





        Statuses.text = "";
    }
    public string overunder(string current, string max)
    {
        return(current + "/" + max);
    }
    public void firststep()
    {
        float HPBWidth = HealthBar.GetComponent<Image>().sprite.rect.width;
        barMaxWidth = HPBWidth;

        HTBRatio = barMaxWidth / character.MaxHealth;
        MTBRatio = barMaxWidth / character.Magic;
        firstStep = true;

    }
}
