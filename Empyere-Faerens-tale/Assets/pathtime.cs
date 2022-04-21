using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pathtime : Collideable
{
    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player")
        {
            // teleporting the player  :D
            //picking certain scene to load for any other scene you would just input the specf name ex. Game or title


            SceneManager.LoadScene("PathtoGargantura");
            coll.transform.position = new Vector3(-494, -774, 0);
            Debug.Log("far away long ago glowing dim as a ember~");
        }
    }
}
