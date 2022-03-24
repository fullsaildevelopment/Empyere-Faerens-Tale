using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogicHandler
{
    Party ally = new Party();
    Party opposition = new Party();
    Character current = new Character();
    Skill selectedSkill = new Skill();
   
    public void StartELH(Skill skill, Character character)
    {
        ally = character.GetParty();
        opposition = ally.Opposition;
        current = character;
        PartyDesignation targetParty;
        int targetPosition;
        ELHSkillDesignation(skill.type, out targetPosition, out targetParty);
        ELHtoCombatHandler(targetPosition, targetParty, selectedSkill);
    }
    public void ELHSkillDesignation(SkillType st, out int position, out PartyDesignation partyDesignation)
    {
        switch (st)
        {
            case SkillType.Damage:
                position = ELHDamage();
                partyDesignation = PartyDesignation.Opposition;
                break;
            case SkillType.Heal:
                position = ELHHeal();
                partyDesignation = PartyDesignation.Ally;
                break;
            case SkillType.Support:
                position = ELHSupport();
                partyDesignation = PartyDesignation.Opposition;
                break;
            default:
                Debug.LogError("No Skill Target");
                position = 0;
                partyDesignation = PartyDesignation.None;
                break;
        }
    }
    //returns 1-4 4 being entire party
    public int ELHDamage()
    {
        int selection = 0;
        int final = 0;
        if (selectedSkill.target == SkillTarget.Party)
        {
            return 4;
        }
        foreach (Character character in opposition.active_characters)
        {
            if (selection == 0)
            {
                selection = 1;
            }
            else if (opposition.active_characters[selection+1].CurrentHealth < character.MaxHealth)
            {
                selection++;
                final = selection;
            }
            else
            {
                selection++;
            }
        }
        return final;
    }
    
    public int ELHHeal()
    {
        int selection = 0;
        int final = 0;
        if(selectedSkill.target == SkillTarget.Self)
        {
            foreach(Character character in ally.active_characters)
            {
                if(character.Name == current.Name)
                {
                    selection++;
                    break;
                }
                else
                {
                    selection++;
                }
            }
            return final;
        }
        else if(selectedSkill.target == SkillTarget.Party)
        { return 4; }
        else
        {
            foreach(Character c in ally.active_characters)
            {
                if(selection == 0)
                {
                    selection++;
                    final = selection;
                }
                if(c.CurrentHealth < ally.active_characters[selection + 1].CurrentHealth)
                {
                    selection++;
                    final = selection;
                }
            }
            return final;
        }

    }
    //For attack type support skills. (Special Cases Coming Soon)
    public int ELHSupport()
    {
        int selection = 0;
        int final = 0;
        if (selectedSkill.target == SkillTarget.Party)
        {
            return 4;
        }
        foreach (Character character in opposition.active_characters)
        {
            if (selection == 0)
            {
                selection = 1;
            }
            else if (opposition.active_characters[selection + 1].CurrentHealth > character.MaxHealth)
            {
                selection++;
                final = selection;
            }
            else
            {
                selection++;
            }
        }
        return final;
    }
    //Messenger function to CombatHandler to execute skill. (apply damage and/or effects)
    public bool ELHtoCombatHandler(int target, PartyDesignation partyDesig, Skill skill)
    {
        return false;
    }

}
