using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogicHandler
{
   
    public void StartELH(Skill skill, Character character)
    {
        Party ally = character.GetParty();
        Party opposition = ally.Opposition;
    }

}
