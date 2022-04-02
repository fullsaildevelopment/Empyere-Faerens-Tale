using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTalk : MonoBehaviour
{
    int collisionCount = 0;
    bool toggle;
    private void Update() {
                if(Input.GetKeyDown(KeyCode.F)||Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButtonDown(1))
                {
                    toggle = true;
                    Debug.Log("Toggled");
                }

    }
    private void OnTriggerStay2D(Collider2D other) {
        Debug.Log("triggers");

        if(toggle)
        {

            
            DialogTrigger dt = GetComponent<DialogTrigger>();
            DialogueManager dm = FindObjectOfType<DialogueManager>();
            //dt includes the character's dialog options
            Debug.Log(dt.dialog.name);
        
        
        
            if(collisionCount==0)
            {
                dt.TriggerDialog();
            }
            else
            {
                dm.DisplayNextSentence();

            }
            collisionCount++;
            if(collisionCount==(dt.dialog.sentences.Length+1))
            {
                collisionCount=0;
                dm.EndDialogue();
            }
            toggle = false;
        }
    }
}

