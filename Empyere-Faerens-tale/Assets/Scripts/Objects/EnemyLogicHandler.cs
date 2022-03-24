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

                break;
            case SkillType.Support:
                break;
            default:
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

}
