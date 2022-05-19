using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleMenuButtons : MonoBehaviour
{
    //Will be refactored to set previous scene as active
    //Unload combat scene

    //[SerializeField] BattleHeart go;
    [SerializeField] List<Animator> selected = new List<Animator>();
    [SerializeField] List<Animator> damaged = new List<Animator>();

    public bool toggle = false;
    public void escape()
    {
        SceneManager.LoadScene(12, LoadSceneMode.Single);
    }
    public void targetAttack()
    {
        if (!toggle)
        {
            BattleHeart go = GameObject.Find("BattleManager").GetComponent<BattleHeart>();
            GameObject.Find("TargetSelector").GetComponent<SelectorParent>().activate(false);
            //GameObject.Find("TargetSelector").GetComponent<SelectorParent>().TargetList = go.enemypartyManager.party.active_characters;
            GameObject.Find("TargetSelector").GetComponent<SelectorParent>().setskill(go.BattleOrder[go.counter].Key.attack);
            GameObject.Find("BattleManager").GetComponent<BattleHeart>().SetButtons(toggle);
            GameObject.Find("BattleManager").GetComponent<BattleHeart>().SetNextTurn(!toggle);
            toggle = true;
        }
        else
        {
            BattleHeart go = GameObject.Find("BattleManager").GetComponent<BattleHeart>();
            GameObject.Find("TargetSelector").GetComponent<SelectorParent>().setbuttons(false);
            //GameObject.Find("TargetSelector").GetComponent<SelectorParent>().TargetList = go.enemypartyManager.party.active_characters;
            GameObject.Find("TargetSelector").GetComponent<SelectorParent>().setskill(go.BattleOrder[go.counter].Key.attack);
            GameObject.Find("BattleManager").GetComponent<BattleHeart>().SetButtons(toggle);
            GameObject.Find("BattleManager").GetComponent<BattleHeart>().SetNextTurn(toggle);
            toggle = false;
        }


    }
    public void Skill()
    {
        skillSelect go = GameObject.Find("SkillSelector").GetComponent<skillSelect>();

    }
    public void attack()
    {
        BattleHeart go = GameObject.Find("BattleManager").GetComponent<BattleHeart>();
        go.enemypartyManager.party.active_characters[pickranomenemy()].CurrentHealth -= (int)(go.BattleOrder[go.counter].Key.attack.modifier * go.BattleOrder[go.counter].Key.Attack + 5);
        Debug.Log(go.BattleOrder[go.counter].Key.Name);
        go.cont = true;
        go.enemypartyManager.update();
        GameObject.Find("BattleManager").GetComponent<BattleHeart>().SetButtons(false);
    }
    public void nextTurn()
    {
        GameObject.Find("BattleManager").GetComponent<BattleHeart>().heartbeat();
        fadeAnimations();

    }
    public int pickranomenemy()
    {
        System.Random random = new System.Random();
        return random.Next(0, 3);
    }
    public void fadeAnimations()
    {
        foreach (Animator animator in damaged)
        {
            if(animator.GetCurrentAnimatorStateInfo(0).IsName("Faded") == false)
            {
                animator.SetTrigger("Fade");
            }

        }
        foreach (Animator animator in selected)
        {
            if(animator.GetCurrentAnimatorStateInfo(0).IsName("SelectedFaded") == false)
            {
                animator.SetTrigger("Fade");
            }
        }
    }
}
