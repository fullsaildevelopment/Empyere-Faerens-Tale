using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathtoPathUnlocked : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(GameObject.Find("Globalvars").GetComponent<GlobalVars>().pathunlocked)
        {
            transform.position = new Vector3 (1230,-210,0);
        }
    }
}
