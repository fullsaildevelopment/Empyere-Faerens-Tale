using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleMenuButtons : MonoBehaviour
{
    //Will be refactored to set previous scene as active
    //Unload combat scene
    public void escape()
    {
        SceneManager.LoadScene(12, LoadSceneMode.Single);
    }
    public void attack()
    {
        BattleHeart go = GameObject.Find("BattleController").GetComponent<BattleHeart>();
        go.enemypartyManager.party.active_characters[pickranomenemy()].CurrentHealth -= (int)(go.BattleOrder[go.counter].Key.attack.modifier * go.BattleOrder[go.counter].Key.Attack);
        go.cont = true;
        go.enemypartyManager.update();
    }
    public int pickranomenemy()
    {
        System.Random random = new System.Random();
        return random.Next(0, 2);
    }
}
