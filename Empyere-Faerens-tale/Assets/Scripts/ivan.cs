using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ivan : MonoBehaviour
{
    public GameObject inventoryboss;
    public bool invent;
    // Start is called before the first frame update
    void Start()
    {
        inventoryboss.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (invent)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {

        inventoryboss.SetActive(true);
        Time.timeScale = 0f;
        invent = true;
    }
    public void Resume()
    {

        inventoryboss.SetActive(false);
        Time.timeScale = 1f;
        invent = false;
    }
}