using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleMenuButtons : MonoBehaviour
{
    //Will be refactored to set previous scene as active
    //Unload combat scene
    public void escape()
    {
        SceneManager.LoadScene(12, LoadSceneMode.Single);
    }
}
