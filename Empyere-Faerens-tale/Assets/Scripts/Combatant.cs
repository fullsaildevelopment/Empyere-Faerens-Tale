using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Combatant : MonoBehaviour
{
   [SerializeField]public int attack ;
  [SerializeField] public int defense;
   [SerializeField]public int speed ;
   [SerializeField]public int magicAttack ;
   [SerializeField]public int magicDefense ;
   [SerializeField]public int health ;
   [SerializeField]public bool isAlly;
   //public string name { get; set; }
   [SerializeField]public Spell[] spells ;
   public bool isTurn;
}
