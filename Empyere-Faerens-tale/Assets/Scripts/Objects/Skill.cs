using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SkillType
{
    Damage,
    Heal,
    Support,
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

    #endregion

    #region Contructors

    public Skill()
    {
        name = null;
        type = SkillType.None;
        damage = DamageType.None;
        target = SkillTarget.None;
        statcheck = StatType.None;
        modifier = 1.0f;
    }
    //Creates basic Attack skill. Give an int of 1
    public Skill(int i)
    {
        if (i == 1)
        {
            name = "Attack";
            type = SkillType.Damage;
            target = SkillTarget.Single;
            statcheck = StatType.Attack;
            damage = DamageType.None;
            modifier = 1.0f;
        }
    }

    #endregion

}
