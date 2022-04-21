using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BattleHeart : MonoBehaviour
{
    User user;
    Party pcparty = new Party();
    Party npcparty;

    [SerializeField] public PartyManager allypartyManager;
    [SerializeField] public PartyManager enemypartyManager;

    private void Awake()
    {
        user = GameObject.Find("GameController").GetComponent<GameUser>().user;
        pcparty = user.party;
        npcparty = GameObject.Find("GameController").GetComponent<EnemyGenLists>().generatedEnemies;

        allypartyManager.party = pcparty;
        enemypartyManager.party = npcparty;

        Debug.Log(GameObject.Find("AllyParty").GetComponent<PartyManager>().party.active_characters[0].Name);

    }
}
