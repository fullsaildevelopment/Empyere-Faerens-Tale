using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatAreaTrigger : MonoBehaviour
{
    // Start is called before the first frame update
     float xpos;
        float ypos;
        float xtotal;
        float ytotal;

        [SerializeField] GameObject player;
    void Start()
    {
        xpos = transform.position.x;
        ypos = transform.position.y;
        xtotal = xpos * transform.localScale.x;
        ytotal = ypos * transform.localScale.y;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Xbounds()&&Ybounds())
        {
            
            int roll = Random.Range(1,1000);
            Debug.Log(roll);
            if(roll%125==0)
            {
                Debug.Log("Rolled");
                FindObjectOfType<SceneSwitcher>().GotoCombatScene();
            }
        }
    }

    bool Xbounds()
    {
        if(player.transform.position.x > xpos && player.transform.position.x < xtotal)
        {
            
            return true;
        }
        return false;
    }
        bool Ybounds()
    {
        if(player.transform.position.y > ypos && player.transform.position.y < ytotal)
        {
            
            return true;
        }
        return false;
    }
}
