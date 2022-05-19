using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectorParent : MonoBehaviour
{
    public GameObject BM;
    [SerializeField] public List<CharacterManager> TargetList;
    [SerializeField] public List<CharacterManager> AllyList;
    [SerializeField] public List<Animator> EnemyDamageAnims;
    [SerializeField] public List<GameObject> gameObjects;
    [SerializeField] public BattleMenuButtons bmb;
    bool allyTarget = false;
    public Skill chosenSkill = new Skill();

    CharacterManager target1;
    CharacterManager target2;
    CharacterManager target3;
    [SerializeField] public List<Text> texts;

    public void activate(bool allyTargets)
    {
        allyTarget = allyTargets;
        this.gameObject.SetActive(true);
        if(allyTargets)
        {
            target1 = AllyList[0];
            target2 = AllyList[1];
            target3 = AllyList[2];
        }
        else
        {
            target1 = TargetList[0];
            target2 = TargetList[1];
            target3 = TargetList[2];
        }

        texts[0].text = target1.character.Name;
        texts[1].text = target2.character.Name;
        texts[2].text = target3.character.Name;
        
        setbuttons(true);
        /*target1.update();
        target2.update();
        target3.update();*/

    }
    public void setskill(Skill skill)
    {
        chosenSkill = skill;
    }
    public void exec(int i)
    {
        if(allyTarget)
        {
            AllyList[i].character.CurrentHealth += (int)(BM.GetComponent<BattleHeart>().BattleOrder[BM.GetComponent<BattleHeart>().counter].Key.Attack * chosenSkill.modifier);
        }
        else
        {
            TargetList[i].character.CurrentHealth -= (int)(BM.GetComponent<BattleHeart>().BattleOrder[BM.GetComponent<BattleHeart>().counter].Key.Attack * chosenSkill.modifier);
            EnemyDamageAnims[i].SetTrigger("Activate");

        }
        setbuttons(false);
        BM.GetComponent<BattleHeart>().enemypartyManager.update();
        BM.GetComponent<BattleHeart>().allypartyManager.update();
        bmb.toggle = false;
        BM.GetComponent<BattleHeart>().SetNextTurn(false);
        
    }
    public void setbuttons(bool b)
    {
        foreach (GameObject go in gameObjects)
        {
            go.SetActive(b);
        }
    }
    public void GameSetButtons(bool b)
    {
        if (b)
        {
            foreach (GameObject go in gameObjects)
            {
                if (go.GetComponent<Text>().text == "Null")
                {
                    go.SetActive(!b);
                }
                else
                {
                    go.SetActive(b);
                }
            }
        }
        else
        {
            foreach(GameObject go in gameObjects)
            {
                go.SetActive(false);
            }
        }
    }
}
