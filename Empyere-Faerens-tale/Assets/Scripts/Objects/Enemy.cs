using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyType
{
    None,
    Attacker,
    Tank,
    //Prioritizes healing
    Healer,
    //Prioritizes buffing and debuffing
    Support,
    //Refer to Boss's individual script WIP
    Boss
}

public class Enemy : Character
{

    #region Members

    public EnemyType type;
    //Holds skills and spells
    public List<Skill> skills;

    #endregion

    #region Contructors

    public Enemy()
    {
        ObjectType = Identiy.Enemy;
        MaxHealth = 0;
        CurrentHealth = 0;
        Speed = 0;
        Attack = 0;
        Defense = 0;
        Magic = 0;
        MagicDefense = 0;
        Name = "Null";
        Class = "Null";
        ElementalAffinity = "Null";

        type = EnemyType.None;
    }

    #endregion

    #region Logic

    public Skill attackerLogic()
    {
        if(CurrentHealth > MaxHealth/2)
        {
            System.Random random = new System.Random();
            int i = random.Next(100);
            if (i > 26)
            {
                return attack;
            }
            List<Skill> options = new List<Skill>();
            foreach (Skill skill in skills)
            {
                if(skill.type == SkillType.Damage)
                {
                    options.Add(skill);
                }
            }
            
            int choice = random.Next(options.Count+1);
            return options[choice];
        }
        else
        {
            System.Random random = new System.Random();
            List<Skill> options = new List<Skill>();
            foreach (Skill skill in skills)
            {
                if(skill.type == SkillType.Heal && skill.target == SkillTarget.Self)
                {
                    if(random.Next(100) > 75)
                    {
                        return skill;
                    }
                }
            }
            int i = random.Next(100);
            if (i > 45)
            {
                return attack;
            }
            foreach (Skill skill in skills)
            {
                if (skill.type == SkillType.Damage)
                {
                    options.Add(skill);
                }
            }

            int choice = random.Next(options.Count + 1);
            return options[choice];

        }
    }

    #endregion

}
