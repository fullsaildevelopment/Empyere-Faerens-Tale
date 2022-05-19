using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Threading;
using UnityEngine.SceneManagement;


public class BattleHeart : MonoBehaviour
{
    User user;
    Party pcparty = new Party();
    Party npcparty = new Party();

    bool battleEnd = false;
    bool battleWon;

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
    bool firstTurn = true;

    
    private void Awake()
    {
        GameObject.Find("TargetSelector").GetComponent<SelectorParent>().setbuttons(false);
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
            BattleOrder[i] = new KeyValuePair<Character,int>(BattleOrder[i].Key, rnd.Next(0, pair.Key.Speed+1));
        }
        Debug.Log("BattleOrder Val Update");

        BattleOrder.Sort((x, y) => y.Value.CompareTo(x.Value)); 
        foreach(KeyValuePair<Character, int> kvp in BattleOrder)
        {
            Debug.Log(kvp.Key.Name);
            Debug.Log(kvp.Value);
        }
        Debug.Log("BattleOrder updated");
        SetButtons(false);
        SetNextTurn(false);

        //heartbeat();

    }
    public void heartbeat()
    {
        {
            if (firstTurn)
            { firstTurn = false; }
            else if (counter >= BattleOrder.Count() - 1)
            {
                counter = 0;
                Debug.Log("Counter reset " + counter);
                turnCounter++;

            }
            else
            {
                counter++;
                turnCounter++;

            }
        }

        //Debug.Log(counter);
        Debug.Log($"Turn: {turnCounter} Current Battle Order : {counter}");
        Debug.Log($"Current: {BattleOrder[counter].Key.Name}");

        //Debug.Log(turnCounter);
        if (!battleEnd)
        {
            if(isPC(BattleOrder[counter].Key) && BattleOrder[counter].Key.CurrentHealth > 0)
            {
                SetButtons(true);
                SetNextTurn(true);


                Debug.Log("PC");
            }
            else if(BattleOrder[counter].Key.CurrentHealth <= 0 && !isPC(BattleOrder[counter].Key))
            {

            }
            
            else
            {
                SetButtons(false);
                SetNextTurn(false);
                int j = pickranomally();
                /*Skill attack = BattleOrder[counter].Key.attack;
                pcparty.active_characters[j].CurrentHealth -= (int)(attack.modifier * BattleOrder[counter].Key.Attack);*/
                enemypartyManager.attack(allypartyManager.party.active_characters[j], BattleOrder[counter].Key);
                allypartyManager.characterManagerArr[j].Damaged.SetTrigger("Activate");
                Debug.Log("NPC");

                //SetButtons(true);

            }
            
            updateAll();
            int enemyDown = 0;
            int allyDown = 0;
            foreach(Character c in enemypartyManager.party.active_characters)
            {
                if(c.CurrentHealth<= 0)
                    enemyDown++;
            }
            foreach(Character c in allypartyManager.party.active_characters)
            {
                if(c.CurrentHealth <= 0)
                    allyDown++;
            }
            if(enemyDown == 3)
            {
                battleEnd = true;
                battleWon = true;
            }
            if(allyDown == 3)
            {
                battleEnd = true;
                battleWon = false;
            }
            if(battleEnd)
            {
                SceneManager.LoadScene(12, LoadSceneMode.Single);
            }

        }


    }
    public void SetButtons(bool flag)
    {
        //Attack.SetActive(flag);
        Skill.SetActive(flag);
        Item.SetActive(flag);
        SwapWep.SetActive(flag);
        SwapArmor.SetActive(flag);
        //NextTurn.SetActive(!flag);
        //Disabled for dev purposes
        //Escape.SetActive(flag);
    }
    public void SetNextTurn(bool flag)
    {
        Attack.SetActive(flag);
        NextTurn.SetActive(!flag);
    }
    public bool isPC(Character c)
    {
        foreach(Character ch in pcparty.active_characters)
        {
            if (c.Name == ch.Name)
            {
                foreach(CharacterManager chm in allypartyManager.characterManagerArr)
                {
                    if(ch.Name == chm.character.Name)
                    {
                        chm.Selected.SetTrigger("Activate");
                    }
                }
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
