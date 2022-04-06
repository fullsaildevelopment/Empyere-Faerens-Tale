using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionVars : MonoBehaviour
{
    // Start is called before the first frame update
    public  bool NorthTrigger = false;
    public  GameObject northEntrance;
    public  bool southTrigger = false;
    public  GameObject southEntrance;
    public  bool westTrigger = false;
    public  GameObject westEntrance;
    public  bool eastTrigger = false;
    public  GameObject eastEntrance;
    public  bool returnTrigger = false;
    public  GameObject returnEntrance;
    public  GameObject Entrance;
    void Start()
    {
        /*
        DontDestroyOnLoad(northEntrance);
        DontDestroyOnLoad(southEntrance);
        DontDestroyOnLoad(westEntrance);
        DontDestroyOnLoad(eastEntrance);
        DontDestroyOnLoad(returnEntrance);
        DontDestroyOnLoad(Entrance);
        */
    }

    
    // Update is called once per frame
    void Update()
    {
        if(NorthTrigger)
        {
            
            NorthTrigger = false;
            Entrance = GameObject.Find("SouthEntrance");
            Debug.Log(Entrance.name);
            WaitForSecondsRealtime waitFor = new WaitForSecondsRealtime(5);
            GameObject.Find("Player").transform.position = new Vector3(Entrance.transform.position.x,Entrance.transform.position.y,Entrance.transform.position.z);
            Debug.Log("NorthTrigger");
        }
        else if(southTrigger)
        {
            southTrigger = false;
            Entrance = GameObject.Find("NorthEntrance");
                        WaitForSecondsRealtime waitFor = new WaitForSecondsRealtime(5);

            GameObject.Find("Player").transform.position= new Vector3(Entrance.transform.position.x,Entrance.transform.position.y,Entrance.transform.position.z);
            Debug.Log("southTrigger");
        }
        else if(eastTrigger)
        {
            eastTrigger = false;
            Entrance = GameObject.Find("WestEntrance");
                        WaitForSecondsRealtime waitFor = new WaitForSecondsRealtime(5);

            GameObject.Find("Player").transform.position= new Vector3(Entrance.transform.position.x,Entrance.transform.position.y,Entrance.transform.position.z);
            Debug.Log("eastTrigger");
        }
        else if(westTrigger)
        {
            westTrigger = false;
            Entrance = GameObject.Find("EastEntrance");
                        WaitForSecondsRealtime waitFor = new WaitForSecondsRealtime(5);

            GameObject.Find("Player").transform.position= new Vector3(Entrance.transform.position.x,Entrance.transform.position.y,Entrance.transform.position.z);
            Debug.Log("westTrigger");
        }
        else if(returnTrigger)
        {
            returnTrigger = false;
            Entrance = GameObject.Find("ReturnEntrance");
                        WaitForSecondsRealtime waitFor = new WaitForSecondsRealtime(5);

            GameObject.Find("Player").transform.position= new Vector3(Entrance.transform.position.x,Entrance.transform.position.y,Entrance.transform.position.z);
            Debug.Log("returnTrigger");
        }
    }
}
