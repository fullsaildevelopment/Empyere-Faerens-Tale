using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NarrationToOpenCutscene : Collideable
{
    // Start is called before the first frame update

    private void Update() {
        if(GameObject.Find("Dialogue").GetComponent<DialogueManager>().isDone == true)
        {
            
            SceneManager.LoadScene("Opening Cutscene");
            transform.position = new Vector3(.88f,-2.52f,0);
        }
        
    }
    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player")
        {
            // teleporting the player  :D
            //picking certain scene to load for any other scene you would just input the specf name ex. Game or title


            SceneManager.LoadScene("Opening Cutscene");
            
            Debug.Log("the hills are alivee");
        }
    }
}
