using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combatmanager : MonoBehaviour
{
    // Start is called before the first frame update
    Combatant[] fighters;
    void Start()
    {
        fighters = FindObjectsOfType<Combatant>();
        Debug.Log(fighters.Length);
    }

    public void Attack(Combatant atkr, Combatant defr)
    {
        defr.health =- atkr.attack;
    }
        public void Spell(Combatant atkr, Combatant defr)
    {
        defr.health =- atkr.spells[1].damage;
    }
        public void Run(Combatant atkr, Combatant defr)
    {
        GameObject.Find("PLAYER").GetComponent<SceneSwitcher>().GotoMenuScene();
    }
        public void Info(Combatant target)
    {
        string display = "HP: " + target.health + " \nAttack: " + target.attack + " \nDefense: " + target.defense + " \nSpeed: " + target.speed + " \nMagicAttack: " + target.magicAttack + " \nMagicDefense: " + target.magicDefense;
        Debug.Log(display);
    }
}
