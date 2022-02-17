﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCCollide : MonoBehaviour
{
    int collisionCount = 0;
    private void OnCollisionEnter2D(Collision2D other) {
        DialogTrigger dt = GetComponent<DialogTrigger>();
        DialogueManager dm = FindObjectOfType<DialogueManager>();
        //dt includes the character's dialog options
        Debug.Log(dt.dialog.name);
        //|| name != dt.dialog.name
        if(collisionCount==(dt.dialog.sentences.Length+1) )
        {
            collisionCount=0;
            dm.EndDialogue();
            Debug.Log("last sentence");

        }
        
        if(collisionCount==0){
        dt.TriggerDialog();
        }
        else{
            dm.DisplayNextSentence();
            Debug.Log("next sentence");
        }
        collisionCount++;

    }
}
