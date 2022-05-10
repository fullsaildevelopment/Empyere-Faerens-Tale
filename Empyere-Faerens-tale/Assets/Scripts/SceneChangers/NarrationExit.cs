using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NarrationExit : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject Dialogue;
    private void Start() {
        Dialogue = GameObject.Find("Dialogue");
    }

    private void Update() {
        if(FindObjectOfType<DialogueManager>().isDone == true)
        
        {
            Debug.Log("made it");
            SceneManager.LoadScene("Opening Cutscene");
            
        }
        
    }
}
