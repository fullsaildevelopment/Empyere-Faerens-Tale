using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


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

    Dictionary<Character, int> BattleOrder = new Dictionary<Character, int>();

    private void Awake()
    {
        user = GameObject.Find("GameController").GetComponent<GameUser>().user;
        pcparty = user.party;
        npcparty = GameObject.Find("GameController").GetComponent<EnemyGenLists>().generatedEnemies;

        allypartyManager.party = pcparty;
        enemypartyManager.party = npcparty;

        System.Random rnd = new System.Random();

        Debug.Log(GameObject.Find("AllyParty").GetComponent<PartyManager>().party.active_characters[0].Name);

        foreach (Character c in pcparty.active_characters)
        {
            if(c.Name != "Null")
                BattleOrder.Add(c, c.Speed);
        }
        foreach (Character c in npcparty.active_characters)
            if(c.Name != "Null")
                BattleOrder.Add(c, c.Speed);

        foreach(KeyValuePair<Character, int> pair in BattleOrder)
        {
            BattleOrder[pair.Key] = rnd.Next(0, pair.Key.Speed);
        }
        
        var temp = from entry in BattleOrder orderby entry.Value ascending select entry;
        BattleOrder = (Dictionary<Character, int>)temp;
        SetButtons(false);

        heartbeat();

    }
    public void heartbeat()
    {
        while(!battleEnd)
        {

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
}
