using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        QuitGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
