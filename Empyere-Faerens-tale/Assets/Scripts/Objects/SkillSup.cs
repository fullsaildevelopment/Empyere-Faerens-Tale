using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Status
{
    Burn,
    Freeze,
    Poison,
    Haste,
    Slow,
    Stop,
    Doom,
    None
}
public class SkillSup : Skill
{
    public float pertick;
    public Status status;
    public SkillSup()
    {
        ObjectType = Identiy.Skill;
        name = null;
        type = SkillType.Support;
        damage = DamageType.None;
        target = SkillTarget.None;
        statcheck = StatType.None;
        //Modifier here tells duration whole numbers only.
        modifier = 1.0f;
        cost = 0;

        //New members
        pertick = 0f;
        status = Status.None;

    }

    //called once at the end of a combat round per skill attached each character.
    //Ex: C1 has burn attached and C2 has poison and freeze. C1 has hearbeat called which only picks up burn. C2's heartbeat itterates through both skills
    //and calls this method.
    public void SkillHeartbeat(Character c)
    {
        switch(status)
        {
            case Status.Burn:
                ApplyDmg(c, this);
                break;
            case Status.Freeze:
                ApplyDmg(c, this);
                break;
            case Status.Poison:
                ApplyDmg(c, this);
                break;
            case Status.Haste:
                TickDown(this);
                break;
            case Status.Slow:
                TickDown(this);
                break;
            case Status.Stop:
                TickDown(this);
                break;
            case Status.Doom:
                TickDown(this);
                break;
            default:
                TickDown(this);
                break;

        }
            
    }
    //Weaknesses can be applied here with slight alter
    public void ApplyDmg(Character c, SkillSup s)
    {
        c.CurrentHealth -= (int)s.pertick;
        TickDown(s);
    }
    public void TickDown(SkillSup s)
    {
        s.modifier--;
    }
}
