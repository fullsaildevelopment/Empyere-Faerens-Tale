using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skillSelect : MonoBehaviour
{
    public List<GameObject> skillExecs;
    public List<Skill> skills; 

    public void activate()
    {
        skills = GameObject.Find("BattleManager").GetComponent<BattleHeart>().BattleOrder[GameObject.Find("BattleManager").GetComponent<BattleHeart>().counter].Key.skillList;
        foreach (GameObject se in skillExecs)
        {
            se.GetComponentInChildren<Text>().text = se.GetComponent<skillExec>().skill.name;
        }
    }

}
