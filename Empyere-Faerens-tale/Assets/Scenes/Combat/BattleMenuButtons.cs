using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleMenuButtons : MonoBehaviour
{
    //Will be refactored to set previous scene as active
    //Unload combat scene

    //[SerializeField] BattleHeart go;
    public void escape()
    {
        SceneManager.LoadScene(12, LoadSceneMode.Single);
    }
    public void attack()
    {
        BattleHeart go = GameObject.Find("BattleManager").GetComponent<BattleHeart>();
        go.enemypartyManager.party.active_characters[pickranomenemy()].CurrentHealth -= (int)(go.allypartyManager.party.active_characters[0].attack.modifier * go.BattleOrder[go.counter].Key.Attack + 5);
        go.cont = true;
        go.enemypartyManager.update();
        GameObject.Find("BattleManager").GetComponent<BattleHeart>().SetButtons(false);
        GameObject.Find("BattleManager").GetComponent<BattleHeart>().heartbeat();
    }
    public void nextTurn()
    {
        GameObject.Find("BattleManager").GetComponent<BattleHeart>().heartbeat();

    }
    public int pickranomenemy()
    {
        System.Random random = new System.Random();
        return random.Next(0, 3);
    }
}
