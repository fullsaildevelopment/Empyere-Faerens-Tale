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

    //Basic Logic for enemies. Need to expand. March 16 22
    #region Logic

    public Skill attackerLogic()
    {
        if (CurrentHealth > MaxHealth / 2)
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
                if (skill.type == SkillType.Damage)
                {
                    options.Add(skill);
                }
            }

            int choice = random.Next(options.Count + 1);
            return options[choice];
        }
        else
        {
            System.Random random = new System.Random();
            List<Skill> options = new List<Skill>();
            foreach (Skill skill in skills)
            {
                if (skill.type == SkillType.Heal && skill.target == SkillTarget.Self)
                {
                    if (random.Next(100) > 75)
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

    //Needs to be expanded
    public Skill tankLogic()
    {
        if (CurrentHealth > MaxHealth / 3)
        {
            System.Random random = new System.Random();
            int i = random.Next(100);
            if (i > 35)
            {
                return attack;
            }
            List<Skill> options = new List<Skill>();
            foreach (Skill skill in skills)
            {
                if (skill.type == SkillType.Support || skill.type == SkillType.Damage)
                {
                    options.Add(skill);
                }
            }

            int choice = random.Next(options.Count + 1);
            return options[choice];
        }
        else
        {
            System.Random random = new System.Random();
            List<Skill> options = new List<Skill>();
            foreach (Skill skill in skills)
            {
                if (skill.type == SkillType.Heal && skill.target == SkillTarget.Self)
                {
                    if (random.Next(100) > 75)
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
                if (skill.type == SkillType.Support)
                {
                    options.Add(skill);
                }
            }

            int choice = random.Next(options.Count + 1);
            return options[choice];
        }

    }

    //Need to refine
    public Skill healerLogic(List<Character> characters)
    {
        if (CurrentHealth > MaxHealth / 3)
        {
            System.Random random = new System.Random();
            int i = random.Next(100);
            if (i > 90)
            {
                return attack;
            }
            List<Skill> options = new List<Skill>();
            foreach (Skill skill in skills)
            {
                if (skill.type == SkillType.Heal)
                {
                    options.Add(skill);
                }
            }
            int partyMax = 0;
            int partyCurrent = 0;
            foreach (Character character in characters)
            {
                partyMax += character.MaxHealth;
                partyCurrent += character.CurrentHealth;
            }
            if (random.Next(partyMax) < partyCurrent)
            {
                return options[random.Next(options.Count + 1)];
            }
        }
        else
        {
            System.Random random = new System.Random();
            List<Skill> options = new List<Skill>();
            foreach (Skill skill in skills)
            {
                if (skill.type == SkillType.Heal && skill.target == SkillTarget.Self)
                {
                    if (random.Next(100) > 80)
                    {
                        return skill;
                    }
                }
            }
            int i = random.Next(100);
            if (i > 95)
            {
                return attack;
            }
            foreach (Skill skill in skills)
            {
                if (skill.type == SkillType.Heal && skill.target == SkillTarget.Party)
                {
                    options.Add(skill);
                }
            }
            if (random.Next(100) > 50)
            {
                return options[random.Next(options.Count + 1)];
            }

            return skills[random.Next(skills.Count + 1)];

        }
        System.Random rand = new System.Random();
        return skills[rand.Next(skills.Count + 1)];
    }

    //Need to refine and expand upon
    public Skill supportLogic()
    {

        if (CurrentHealth > MaxHealth / 2)
        {
            System.Random random = new System.Random();
            int i = random.Next(100);
            if (i > 67)
            {
                return attack;
            }
            List<Skill> options = new List<Skill>();
            if (random.Next(100) > 50)
            {
                foreach (Skill skill in skills)
                {
                    if (skill.type == SkillType.Damage)
                    {
                        options.Add(skill);
                    }
                }
                return options[random.Next(options.Count + 1)];
            }
            else
            {
                foreach( Skill skill in skills)
                {
                    if(skill.type == SkillType.Support || skill.type == SkillType.Heal)
                    {
                        options.Add(skill);
                    }
                }
            }
        }
        else
        {
            System.Random random = new System.Random();
            List<Skill> options = new List<Skill>();
            foreach (Skill skill in skills)
            {
                if (skill.type == SkillType.Heal && skill.target == SkillTarget.Self || skill.type == SkillType.Heal && skill.target == SkillTarget.Party)
                {
                    options.Add(skill);
                }
            }
            int i = random.Next(100);
            if (i > 80)
            {
                return attack;
            }
            if(i > 30 && i < 79)
            {
                return options[random.Next(options.Count + 1)];
            }

        }
        System.Random rand = new System.Random();
        return skills[rand.Next(skills.Count + 1)];

    }


    #endregion
}

