using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatAreaTrigger: Collideable
{
    
    private void OnTriggerStay2D(Collider2D other) {
        int random = Random.Range(1,500);
        
        if (random == 1)
        {
            Debug.Log("bad luck");
            GameObject.Find("CombatEncounter Trigger").GetComponent<EnemyGenLists>().GenerateCombat();
        }
    }
}