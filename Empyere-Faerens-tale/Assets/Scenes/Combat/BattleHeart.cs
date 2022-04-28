using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Threading;


public class BattleHeart : MonoBehaviour
{
    User user;
    Party pcparty = new Party();
    Party npcparty = new Party();

    bool battleEnd = false;

    [SerializeField] public PartyManager allypartyManager;
    [SerializeField] public PartyManager enemypartyManager;
    [SerializeField] public GameObject Attack;
    [SerializeField] public GameObject Skill;
    [SerializeField] public GameObject Item;
    [SerializeField] public GameObject SwapWep;
    [SerializeField] public GameObject SwapArmor;
    [SerializeField] public GameObject Escape;
    [SerializeField] public GameObject NextTurn;

    public List<KeyValuePair<Character, int>> BattleOrder = new List<KeyValuePair<Character, int>>();

    public Skill selectedSkill = new Skill();
    public bool cont = false;
    int turnCounter = 0;
    public int counter = 0;

    
    private void Awake()
    {
        user = GameObject.Find("GameController").GetComponent<GameUser>().user;
        pcparty = user.party;
        int j = 0;
        foreach(Character c in npcparty.active_characters)
        {
            npcparty.active_characters[j] = GameObject.Find("GameController").GetComponent<EnemyGenLists>().generatedEnemies.active_characters[j];
            j++;
        }

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

        //heartbeat();

    }
    public void heartbeat()
    {
        Debug.Log(counter);
        //Debug.Log(turnCounter);
        if(!battleEnd)
        {
            if(isPC(BattleOrder[counter].Key))
            {
                SetButtons(true);


                Debug.Log("PC");
            }
            
            else
            {
                SetButtons(false);
                int j = pickranomally();
                /*Skill attack = BattleOrder[counter].Key.attack;
                pcparty.active_characters[j].CurrentHealth -= (int)(attack.modifier * BattleOrder[counter].Key.Attack);*/
                enemypartyManager.attack(allypartyManager.party.active_characters[j], BattleOrder[counter].Key);
                Debug.Log("NPC");

                //SetButtons(true);

            }
            if (counter >= BattleOrder.Count()-1)
            {
                counter = 0;
                Debug.Log("Counter reset " + counter);
            }
            else
            {
                counter++;
            }
            updateAll();
            turnCounter++;
            Debug.Log($"Turn: {turnCounter} Current Battle Order {counter}");

            /*if (BattleOrder[counter + 1].Key.Name == allypartyManager.party.active_characters[0].Name ||
                BattleOrder[counter + 1].Key.Name == allypartyManager.party.active_characters[1].Name ||
                BattleOrder[counter + 1].Key.Name == allypartyManager.party.active_characters[2].Name)*/
            
            

            //heartbeat();
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
        NextTurn.SetActive(!flag);
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
        //heartbeat();
        return random.Next(0, 2);
    }
    
    public void updateAll()
    {
        allypartyManager.update();
        enemypartyManager.update();
    }
}
