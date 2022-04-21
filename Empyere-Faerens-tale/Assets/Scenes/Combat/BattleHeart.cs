using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Threading;


public class BattleHeart : MonoBehaviour
{
    User user;
    Party pcparty = new Party();
    Party npcparty;

    bool battleEnd = false;

    [SerializeField] public PartyManager allypartyManager;
    [SerializeField] public PartyManager enemypartyManager;
    [SerializeField] public GameObject Attack;
    [SerializeField] public GameObject Skill;
    [SerializeField] public GameObject Item;
    [SerializeField] public GameObject SwapWep;
    [SerializeField] public GameObject SwapArmor;
    [SerializeField] public GameObject Escape;

    public List<KeyValuePair<Character, int>> BattleOrder = new List<KeyValuePair<Character, int>>();

    public Skill selectedSkill = new Skill();
    public bool cont = false;
    int turnCounter = 0;
    public int counter = 0;

    
    private void Awake()
    {
        user = GameObject.Find("GameController").GetComponent<GameUser>().user;
        pcparty = user.party;
        npcparty = GameObject.Find("GameController").GetComponent<EnemyGenLists>().generatedEnemies;

        allypartyManager.party = pcparty;
        enemypartyManager.party = npcparty;

        System.Random rnd = new System.Random();

        //Debug.Log(GameObject.Find("AllyParty").GetComponent<PartyManager>().party.active_characters[0].Name);
        Debug.Log("Start Battleorder");

        foreach (Character c in pcparty.active_characters)
        {
            if (c.Name != "Null")
            {
                KeyValuePair<Character,int> pair = new KeyValuePair<Character,int>(c, c.Speed);
                BattleOrder.Add(pair);
            }
        }
        Debug.Log("PC BattleOrder");
        foreach (Character c in npcparty.active_characters.ToList())
            if (c.Name != "Null")
            {
                KeyValuePair<Character, int> pair = new KeyValuePair<Character, int>(c, c.Speed);
                BattleOrder.Add(pair);
            }
        Debug.Log("NPC BattleOrder");
        int i = 0;
        foreach(KeyValuePair<Character, int> pair in BattleOrder.ToList())
        {
            BattleOrder[i] = new KeyValuePair<Character,int>(BattleOrder[i].Key, rnd.Next(0, pair.Key.Speed));
        }
        Debug.Log("BattleOrder Val Update");

        BattleOrder.Sort((x, y) => x.Value.CompareTo(y.Value)); 
        foreach(KeyValuePair<Character, int> kvp in BattleOrder)
        {
            Debug.Log(kvp.Value);
        }
        Debug.Log("BattleOrder updated");
        SetButtons(false);

        heartbeat();

    }
    public void heartbeat()
    {
        Thread.Sleep(40);
        Debug.Log(counter);
        //Debug.Log(turnCounter);
        if(!battleEnd)
        {
            if(isPC(BattleOrder[counter].Key))
            {
                //SetButtons(true);
                for(int i = 0; i < 20; i++)
                {
                    if (cont)
                        break;
                    Thread.Sleep(500);
                }
                cont = false;
                Debug.Log("PC");
            }
            
            else
            {
                int j = pickranomally();
                Skill attack = BattleOrder[counter].Key.attack;
                pcparty.active_characters[j].CurrentHealth -= (int)(attack.modifier * BattleOrder[counter].Key.Attack);
            }
            Debug.Log("NPC");
            if(counter == 5)
            {
                counter = 0;
                Debug.Log("Counter reset " + counter);
            }
            counter++;
            turnCounter++;
            updateAll();
            if (turnCounter < 6)
                Debug.Log("Before beat " + turnCounter);
            heartbeat();
            /*battleEnd = true;
            heartbeat();*/

        }


    }
    public void SetButtons(bool flag)
    {
        Attack.SetActive(flag);
        Skill.SetActive(flag);
        Item.SetActive(flag);
        SwapWep.SetActive(flag);
        SwapArmor.SetActive(flag);
        //Disabled for dev purposes
        //Escape.SetActive(flag);
    }
    public bool isPC(Character c)
    {
        foreach(Character ch in pcparty.active_characters)
        {
            if (c.Name == ch.Name)
            {
                return true;
            }

        }
        return false;
    }
    public int pickranomally()
    {
        System.Random random = new System.Random();
        return random.Next(0, 1);
    }
    
    public void updateAll()
    {
        allypartyManager.update();
        enemypartyManager.update();
    }
}
