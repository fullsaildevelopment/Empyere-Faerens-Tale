using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SkillType
{
    Damage,
    Heal,
    Support,
    Tank,
    None
}
public enum SkillTarget
{
    Single,
    Self,
    Party,
    All,
    None
}
public enum DamageType
{
    None,
    Fire,
    Water,
    Earth,
    Ice,
    Pure
}
public enum StatType
{
    Attack,
    Magic,
    Defense,
    Speed,
    None
}
public class Skill : BaseObject
{

    #region Members

    public string name;
    public SkillType type;
    public DamageType damage;
    public SkillTarget target;
    public StatType statcheck;
    //Modifier for damage/effectivness. modifier * character stat
    public float modifier;
    public int cost;

    #endregion

    #region Contructors

    public Skill()
    {
        ObjectType = Identiy.Skill;
        name = null;
        type = SkillType.None;
        damage = DamageType.None;
        target = SkillTarget.None;
        statcheck = StatType.None;
        modifier = 1.0f;
        cost = 0;
    }
    //Creates basic Attack skill. Give an int of 1
    public Skill(int i)
    {
        if (i == 1)
        {
            ObjectType = Identiy.Skill;
            name = "Attack";
            type = SkillType.Damage;
            target = SkillTarget.Single;
            statcheck = StatType.Attack;
            damage = DamageType.None;
            modifier = 1.0f;
            cost = 0;
        }
    }
    /*public void AttachSkill(Character c)
    {
        if (c.Statuses.ContainsKey(this) == true && c.Statuses[this] < 3)
        {
            c.Statuses[this]++;
        }
        else if (c.Statuses.ContainsKey(this) != true)
        {
            c.Statuses.Add(this, 1);
        }
        else
        {
            return;
        }
    }*/
    #endregion

}
