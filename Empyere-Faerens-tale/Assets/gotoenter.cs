using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotoenter : Collideable
{

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player")
        {
            // teleporting the player  :D
            //picking certain scene to load for any other scene you would just input the specf name ex. Game or title


            SceneManager.LoadScene("Game");
            Debug.Log("leaving castle to go to courtyard");
        }
    }
}
