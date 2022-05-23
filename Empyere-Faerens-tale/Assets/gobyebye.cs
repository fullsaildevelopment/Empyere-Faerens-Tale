using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gobyebye : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject inventoryboss;
       public GameObject pauseScreen;
       public bool invent;
       public bool ispaused;
    void Start()
    {
        inventoryboss.SetActive(false);
        pauseScreen.SetActive(false);

        invent = false;
        ispaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
