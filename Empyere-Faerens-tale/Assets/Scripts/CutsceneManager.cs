using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneManager : MonoBehaviour
{
    private Queue<Cutscene> scenes;

    void Start() {
    scenes = new Queue<Cutscene>();
        
    }

    public void StartCutscene(Cutscene scene)
    {
        scenes.Clear();
        scenes.Enqueue(scene);
        DisplayNextScene();
        
    }
    public void DisplayNextScene()
    {
        if(scenes.Count == 0)
        {
            EndScene();
            return;
        }
        else{
            Cutscene current = scenes.Dequeue();
            //CutsceneTrigger.PlayScene(current);
        }
    }
    public void EndScene()
    {
        Debug.Log("Scene over");
    }

}
