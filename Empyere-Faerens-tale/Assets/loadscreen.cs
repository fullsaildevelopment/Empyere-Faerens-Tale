using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscreen : MonoBehaviour
{//hi I inherit player so i can load where the player is if the user saved 
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        Scene scene = SceneManager.GetActiveScene();
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];

        transform.position = position;
    }
}
