using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneTrigger : MonoBehaviour
{
    
    public Cutscene cutscene;
    void triggerCutscene()
    {
        
        FindObjectOfType<CutsceneManager>().StartCutscene(cutscene);
    }
        public void PlayScene(Cutscene scene)
    {
        
    }

}
