using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    public bool isAttack {get;set;}
    public bool isSpell {get;set;}
    public bool isInfo{get;set;}
    public bool isItem {get;set;}
    // Start is called before the first frame update
    void Start()
    {
    isAttack = false;
    isSpell = false;
    isInfo = false;
    isItem = false;
    }

    // Update is called once per frame
  public void useAttack()
  {
      if(isAttack)
      {
          Debug.Log("attack");
          Component player = GetComponent("Player");
          Component enemy = GetComponent("Enemy");

          enemy.GetComponent("HealthBar").GetComponent<HealthModulator>().currHealth =- player.GetComponent("Player_0").GetComponent<StatBlocks>().Attack;
      }
      isAttack = false;
  }
    public void useSpell()
  {
            if(isSpell)
      {
          
      }
      isSpell = false;
  }
    public void useInfo()
  {
            if(isInfo)
      {
          
      }
      isInfo = false;
  }
    public void useItem()
  {
            if(isItem)
      {
          
      }
      isItem = false;
  }
}
