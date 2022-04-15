using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class plainstocastle : Collideable
{
    // Start is called before the first frame update
     protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player")
        {
            // teleporting the player  :D
            //picking certain scene to load for any other scene you would just input the specf name ex. Game or title


            SceneManager.LoadScene("innercastle");
            coll.transform.position = new Vector3(1276,-171,0);
            Debug.Log("the hills are alivee");
        }
    }
}
