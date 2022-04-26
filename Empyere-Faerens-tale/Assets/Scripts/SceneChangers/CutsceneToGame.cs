using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneToGame : Collideable
{
    protected override void OnCollide(Collider2D coll)
    {
        
        
            // teleporting the player  :D
            //picking certain scene to load for any other scene you would just input the specf name ex. Game or title


            SceneManager.LoadScene("innercastle");
            coll.transform.position = new Vector3(820,-274,0);
            Debug.Log("come on jeffery you can do it...");
        
    }
}
