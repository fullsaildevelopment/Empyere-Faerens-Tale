using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTank : Skill
{
    //aggroTarget may not be used. May be removed later.
    public Character aggroTarget;
    public bool dot = false;
    public float pertick;
    public SkillTank()
    {
        ObjectType = Identiy.Skill;
        name = null;
        type = SkillType.Tank;
        damage = DamageType.None;
        target = SkillTarget.None;
        statcheck = StatType.None;
        //Modifier here tells duration. Whole numbers only.
        modifier = 1.0f;
        cost = 0;

        //New Members
        aggroTarget = new Character();
        pertick = 0;

    }
    //called once at the end of a combat round per skill attached each character.
    //Ex: C1 has burn attached and C2 has poison and freeze. C1 has hearbeat called which only picks up burn. C2's heartbeat itterates through both skills
    //and calls this method.
    //Tank classed skills should only hold aggro after the initial damage is done. This is where the aggro time is managed.
    //Also if a tank skill has a dot it can be handled here as well.
    public void SkillHeartbeat(Character c)
    {
        switch(dot)
        {
            case true:
                DOTTick(c, this);
                break;
            case false:
                TickDown(this);
                break;
        }
    }
    public void TickDown(SkillTank s)
    {
        s.modifier--;
    }
    public void DOTTick(Character c, SkillTank s)
    {
        c.CurrentHealth -= (int)pertick;
        TickDown(s);
    }
}
