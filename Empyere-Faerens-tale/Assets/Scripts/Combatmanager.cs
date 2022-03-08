using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combatmanager : MonoBehaviour
{
    // Start is called before the first frame update
    Combatant[] fighters;
    Combatant[] Enemies;
    Combatant[] Allies;
    
    void Start()
    {
        fighters = FindObjectsOfType<Combatant>();
       
        int allycount = 0;
        int enemycount = 0;
        for(int i = 0; i<fighters.Length; i++)
        {
            
            if(fighters[i].isAlly == true )
            {
                
                allycount++;
                
            }
            else{
                enemycount++;
            }
        }
        Enemies = new Combatant[enemycount];
        Allies = new Combatant[allycount];
        allycount = 0;
        enemycount = 0;
        for(int i = 0; i<fighters.Length; i++)
        {
            
            if(fighters[i].isAlly == true )
            {
                Allies[allycount] = fighters[i];
                allycount++;
                
            }
            else{
                Enemies[enemycount] = fighters[i];
                enemycount++;
            }
        }
        fighters = RollInitiative();
        fighters[0].isTurn = true;

    }
    public void Update()
    {
        Combatant current = CurrentTurn();
        //Debug.Log(current.name);
        if(!current.isAlly)
        {
            int target = Random.Range(0, Allies.Length);
            Attack(Allies[target]);
            //NextTurn();
        }
        bool isOver = BattleEndCheck();
        if(isOver)
        {
            Debug.Log("Battle over");
        }
    }
    public void Attack(Combatant defr)
    {
        Combatant atkr = CurrentTurn();
        defr.health = defr.health- atkr.attack;
        if(defr.health < 0)
        {
            defr.health = 0;
        }
        Debug.Log(defr.name + ": " + defr.health);

        NextTurn();
    }
        public void Spell(Combatant defr)
    {
        Combatant atkr = CurrentTurn();
        defr.health =- atkr.spells[1].damage;
        NextTurn();
    }
        public void Run()
    {
        GameObject.Find("Rin").GetComponent<SceneSwitcher>().GotoMenuScene();

//        tmp.Transform.position.Set(0,0,0);
    }
        public void Info(Combatant target)
    {
        string display = "HP: " + target.health + " Attack: " + target.attack + " Defense: " + target.defense + " Speed: " + target.speed + " MagicAttack: " + target.magicAttack + " MagicDefense: " + target.magicDefense;
        Debug.Log(display);
        NextTurn();
        
        
        GameObject textfield = GameObject.Find("placeholder");
        textfield.GetComponent<Text>().text= display;
        
        
    }
    private bool BattleEndCheck()
    {
        bool final = false;
        bool alliesleft = false;
        bool enemiesleft = false;
        for(int i =0 ; i<Enemies.Length; i++)
        {
            if(Enemies[i].health >0)
            {
                enemiesleft = true;
                
            }
            

        }
        for(int i =0 ; i<Allies.Length; i++)
        {
            if(Allies[i].health >0)
            {
                alliesleft = true;
            }
            
        }
        if(alliesleft && enemiesleft)
        {
            return false;
        }
        final = true;
        return final;
    }

    private Combatant[] RollInitiative()
    {
        Combatant[] order = fighters;
       
        //while(notInOrder == true){
        for(int i = 0; i<order.Length-1;i++)
        {
            Combatant tmp;
            tmp = order[i];
            if(order[i].speed <order[i+1].speed)
            {
                order[i] = order[i+1];
                order[i+1] = tmp;
                
            }

        }
        for(int i=0;i<order.Length-1;i++)
        {
            if(order[i].speed > order[i+1].speed)
            {
                
            }
        }
        
        

        return order;
    }
    private Combatant CurrentTurn()
    {
        Combatant cur = fighters[0];
        for(int i = 0;i<fighters.Length;i++)
        {
            if(fighters[i].isTurn)
            {
                cur= fighters[i];
            }
        }
        return cur;
    }
    private void NextTurn()
    {
        for(int i=0;i<fighters.Length;i++)
        {
            if(fighters[i] == CurrentTurn())
            {
                fighters[i].isTurn = false;
                if(i == fighters.Length-1)
                {
                    
                    fighters[0].isTurn = true;
                    break;
                }
                else{
                    
                    
                    fighters[i+1].isTurn = true;
                    break;
                }
                
            }

        }
    }

}
