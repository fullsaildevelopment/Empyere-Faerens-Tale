using System.Collections.Generic;

public class EnemyLogicHandler
{
    public List<Character> PlayerParty = new List<Character>();
    public List<Character> EnemyParty = new List<Character>();

    public EnemyLogicHandler()
    {
    }

    //Insert active_characters for player and NPC parties
    public EnemyLogicHandler(List<Character> PCParty, List<Character> NPCParty)
    {
        PlayerParty = PCParty;
        EnemyParty = NPCParty;
    }

    public void heartbeat()
    {
        foreach (Character c in PlayerParty)
        {
            foreach (Skill s in c.Statuses.Keys)
            {
                if (s.type == SkillType.Support)
                {
                    SkillSup ts = s as SkillSup;
                    ts.SkillHeartbeat(c);
                }
                if (s.type == SkillType.Tank)
                {
                    SkillTank ts = s as SkillTank;
                    ts.SkillHeartbeat(c);
                }
            }
        }
        foreach (Character c in EnemyParty)
        {
            foreach (Skill s in c.Statuses.Keys)
            {
                if (s.type == SkillType.Support)
                {
                    SkillSup ts = s as SkillSup;
                    ts.SkillHeartbeat(c);
                }
                if (s.type == SkillType.Tank)
                {
                    SkillTank ts = s as SkillTank;
                    ts.SkillHeartbeat(c);
                }
            }
        }
    }

    //Enemies only!!!!
    public Skill SkillSelectLogic(List<Character> p, Enemy e)
    {
        Skill s = new Skill();
        switch (e.type)
        {
            case EnemyType.Tank:
                s = e.tankLogic();
                break;

            case EnemyType.Attacker:
                s = e.attackerLogic();
                break;

            case EnemyType.Healer:
                s = e.healerLogic(p);
                break;

            case EnemyType.Support:
                s = e.supportLogic();
                break;

            default:
                break;
        }
        return s;
    }
    public void ApplySkill(Character target, Skill skill)
    {
        if(skill.type == SkillType.Tank || skill.type == SkillType.Support)
        {
            skill.AttachSkill(target);
        }
        if(skill.type == SkillType.Damage)
        {
            target.CurrentHealth -= (int)skill.modifier;
        }
        if(skill.type == SkillType.Heal)
        {
            target.CurrentHealth += (int)skill.modifier;
        }
    }
}